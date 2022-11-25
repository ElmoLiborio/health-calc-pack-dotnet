using health_calc_pack_dotnet.Interfaces;

namespace health_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double Calc(double Height, double Weigth)
        {
            try
            {
                var result = Math.Round(Weigth / (Math.Pow(Height, 2)), 2);
                return result;
            }
            catch 
            {
                throw;
            }
        }

       
        public string GetIMCCategory(double IMC)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(double Height, double Weigth)
        {
            throw new NotImplementedException();
        }
    }
}