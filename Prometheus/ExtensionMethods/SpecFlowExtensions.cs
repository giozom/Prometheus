namespace TechTalk.SpecFlow
{
    public static class SpecFlowExtensions
    {
        public static string GetColumn(this TableRow row, string columnName)
        {
            try
            {
                return row[columnName];
            }
            catch (System.Exception)
            {
                throw new SpecFlowException(string.Format("SpecFlow Couldn't find the value '{0}' in a table.", columnName));
            }
            
        }
    }
}
