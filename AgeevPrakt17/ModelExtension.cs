namespace AgeevPrakt17
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class AgeevBDEntities : DbContext
    {
        private static AgeevBDEntities context;

        public static AgeevBDEntities GetContext()
        {
            if (context == null) context = new AgeevBDEntities();
            return context;
        }
    }
}
