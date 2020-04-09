using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gear
{
    public partial class Form1 : Form
    {
        private double speed = 1;
        private int time = 0;
        private readonly Random rnd = new Random();
        private List<Gear> gears = new List<Gear>();

        private int nextGearTime = 0;
        private int secondProcessedGears = 0;
        private int secondHardeningGears = 0;
        private int processedGears = 0;
        private int createdGears = 1;

        private List<int> processingTimes = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speed = (double)speed / 2;
            ChangeSpeed();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speed *= 2;
            ChangeSpeed();
        }

        private void ChangeSpeed()
        {
            SpeedLabel.Text = $"Скорость: х{1 / speed}";
            timer1.Interval = (int)(Math.Round(speed, 3) * 1000);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)Math.Round(speed, 0) * 1000;
            timer1.Start();
            this.Processing();
            startBtn.Visible = false;
        }

        private void Processing()
        {
            gears.Add(new Gear(time, Randomizer.CementationTime(rnd) + Randomizer.HardeningTime(rnd)));
            nextGearTime = time + Randomizer.NextGearTime(rnd);
        }

        //тик таймера = 1 минуте модельного времени
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            //отправка на обработку новой шестерни
            if (time == nextGearTime && createdGears < 400)
            {
                gears.Add(new Gear(time, Randomizer.CementationTime(rnd) + Randomizer.HardeningTime(rnd)));
                nextGearTime += Randomizer.NextGearTime(rnd);
                createdGears++;
            }

            //каждые 20 минут пересчитываем среднее время обработки шестерни
            if (time % 20 == 0)
            {
                if (processingTimes.Count() != 0)
                    RoundProcessingTimeLabel.Text = $"{Math.Round(processingTimes.Average(), 2)} мин";
            }

            //проходимся по коллекции шестерен и решаем что с каждой делать, если их время обработки закончилось
            foreach (var g in gears.Where(x => x.ProcessingEndTime == time))
            {
                int t = g.ProcessingEndTime - g.ProcessingStartTime;
                if (t > 25)
                {
                    processedGears++;
                    ProcessedLabel.Text = processedGears.ToString();
                    processingTimes.Add(g.ProcessingEndTime - g.ProcessingStartTime);

                    if (processedGears == 400)
                    {
                        timer1.Stop();
                        RoundProcessingTimeLabel.Text = $"{Math.Round(processingTimes.Average(), 2)} мин";

                        SecHardLabel.Text = secondHardeningGears.ToString() + " "
                            + (Math.Round((double)secondHardeningGears / 400, 2) * 100).ToString() + "%";
                        SecProcLabel.Text = secondProcessedGears.ToString() + " "
                            + (Math.Round((double)secondProcessedGears / 400, 2) * 100).ToString() + "%";

                        MessageBox.Show("Обработка 400 деталей закончилась!");
                    }
                }
                else if (t >= 20 && t <= 25)
                {
                    g.ProcessingEndTime += Randomizer.HardeningTime(rnd);
                    secondHardeningGears++;
                    SecHardLabel.Text = secondHardeningGears.ToString();
                }
                else
                {
                    g.ProcessingEndTime += Randomizer.HardeningTime(rnd) + Randomizer.CementationTime(rnd);
                    secondProcessedGears++;
                    SecProcLabel.Text = secondProcessedGears.ToString();
                }
            }

            gears.RemoveAll(x => x.ProcessingEndTime == time);
            TimeLabel.Text = $"{time} мин";
        }
    }
}