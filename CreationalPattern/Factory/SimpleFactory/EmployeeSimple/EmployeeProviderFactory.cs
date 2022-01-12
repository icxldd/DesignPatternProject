namespace Factory.SimpleFactory.EmployeeSimple
{
    public static class EmployeeProviderFactory
    {
        public static IEmployee CreateDbProvider(EmployeeType dbType)
        {
            IEmployee provider = null;
            switch (dbType)
            {
                case EmployeeType.Reception:
                    provider = new ReceptionProvider();
                    break;
                case EmployeeType.Programmer:
                    provider = new ProgrammerProvider();
                    break;
                case EmployeeType.Boss:
                    provider = new BossProvider();
                    break;
                default:
                    break;
            }

            return provider;
        }
    }
}