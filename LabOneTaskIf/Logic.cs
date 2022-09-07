namespace LabOneTaskIf
{
    public class Logic
    {
        public static string GetCost(int fullCost)
        { 
            var rubbles = fullCost / 100;
            var cents = fullCost % 100; 
            var finalPrice = $"{rubbles} rubbles and {cents} cents"; 
            return (finalPrice);
        }
    }
}