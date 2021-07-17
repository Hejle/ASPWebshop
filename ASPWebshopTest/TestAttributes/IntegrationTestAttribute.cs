using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ASPWebshopTest.TestAttributes
{
    public class IntegrationTestAttribute : TestCategoryBaseAttribute
    {
        public override IList<string> TestCategories { get; }

        public IntegrationTestAttribute()
        {
            this.TestCategories = new List<string>(1);
            this.TestCategories.Add("IntegrationTest");
        }
    }
}
