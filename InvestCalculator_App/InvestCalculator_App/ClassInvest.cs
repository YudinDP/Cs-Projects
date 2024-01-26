using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestCalculator_App
{
    public class ClassInvest
    {
        //входные значения
        private double Sum;
        private int Time;
        private double PercentYear;
        private int timeReinvest;
        private double sumReinvest;

        //полученные значения 
        private double sumFinal;
        private double sumReinvestFinal;
        private double profit;

        ///конструктор
        public ClassInvest(){ 
          //входные значения
        this.Sum = 0;
        this.Time = 0;
            this.PercentYear = 0;
            this.timeReinvest = 0;
        this.sumReinvest = 0;

        //полученные значения 
        this.sumFinal = 0;
        this.sumReinvestFinal = 0;
        this.profit = 0;
    
    }

        public void Calculate(double startSum, int timeMonths, double percentYear, int tReinvest = 0, double sReinvest = 0) {
            this.sumFinal = 0;
            this.sumReinvestFinal = 0;
            this.profit = 0;

            this.Sum = startSum;
            this.Time = timeMonths;
            this.PercentYear = percentYear / 100;
            this.timeReinvest = tReinvest;
            this.sumReinvest = sReinvest;

            double currentSum = this.Sum;
            int re = 1; //счетчик для определения того, когда зачислять реинвестицию
            for (int i = 1; i <= this.Time; i++)
            {
                if (re == this.timeReinvest)
                {
                    currentSum += this.sumReinvest;
                    this.sumReinvestFinal += this.sumReinvest;
                    re = 1;
                }
                else re++;

                currentSum += (currentSum * (this.PercentYear / 12));
            }
            this.sumFinal = currentSum;
            this.profit = this.sumFinal - (this.Sum + this.sumReinvestFinal);
        
        }



        //геттер итоговый суммы после инвестиций
        public double GetFinalSum() { 
            return this.sumFinal;
        }

        //геттер итоговый суммы реинвестиций
        public double GetFinalReinvestSum()
        {
            return this.sumReinvestFinal;
        }

        //геттер прибыли после всех инвестиций
        public double GetProfit()
        {
            return this.profit;
        }


    }
}
