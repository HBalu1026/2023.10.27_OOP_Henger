using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Cso : Henger
    {
        private int falVastagsag;

        public Cso(double sugar, double magassag) :base(sugar, magassag)
        {
            falVastagsag = 1;
        }

        public Cso(double sugar, double magassag, double falVastagag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagag;
        }

        public int FalVastagsag { get => falVastagsag; }

        public void Terfogat() => base.Terfogat() - Math.Pow(GetSugar - falVastagsag, 2) * Math.PI * GetMagassag;

        public void ToString() => base.ToString() + $"falvastagsága:{falVastagsag}";
    }
}