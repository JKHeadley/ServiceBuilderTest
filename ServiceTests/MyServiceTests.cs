using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceTests.ServiceReference1;

namespace ServiceTests
{
    [TestClass]
    public class MyServiceTests
    {
        [TestMethod]
        public void TestSomeServiceCalls()
        {
            using (var svc = new ServiceClient())
            {
                OrganizationDTO org = new OrganizationDTO { Name = "MyOrg" };
                var createdOrg = svc.CreateOrganization(org);
                var test = "cool";
                createdOrg.Name = "Bobs";
                var updatedOrg = svc.UpdateOrganization(createdOrg);
                test = "uhuh";
                int deleted = svc.DeleteOrganizationById(updatedOrg.Id);
                test = "yup";
                var orgs = svc.GetOrganizations();
                test = "yay!";
            }
        }
    }
}
