using System;
namespace Crime_Analyzer
{
    public class CrimeStats
    {
        public int Year;
        public int Population;
        public int ViolentCrime;
        public int Theft;
        public int Burglary;
        public int AggravatedAssualt;
        public int MotorVehicleTheft;
        public int PropertyCrime;
        public int Robbery;
        public int Rape;
        public int Murder;

        public CrimeStats(int year, int population, int violentCrime, int theft, int burglary, int aggravatedAssualt, int motorVehicleTheft, int propertyCrime, int robbery, int rape, int murder)
        {
            Year = year;
            Population = population;
            ViolentCrime = violentCrime;
            Theft = theft;
            Burglary = burglary;
            AggravatedAssualt = aggravatedAssualt;
            MotorVehicleTheft = motorVehicleTheft;
            PropertyCrime = propertyCrime;
            Robbery = robbery;
            Rape = rape;
            Murder = murder;
        }
    }
}