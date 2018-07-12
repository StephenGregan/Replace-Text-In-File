using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndReplaceInFile
{
    class Program
    {
        static void Main(string[] args)
        {

            String batch1 = File.ReadAllText(@"C:\Users\Ronan\source\repos\search-dotnet-asp-net-mvc-jobs-master\NYCJobsWeb\Schema_and_Data\allcontacts1.json");
            String batch2 = File.ReadAllText(@"C:\Users\Ronan\source\repos\search-dotnet-asp-net-mvc-jobs-master\NYCJobsWeb\Schema_and_Data\allcontacts2.json");
            String batch3 = File.ReadAllText(@"C:\Users\Ronan\source\repos\search-dotnet-asp-net-mvc-jobs-master\NYCJobsWeb\Schema_and_Data\allcontacts3.json");
            String batch4 = File.ReadAllText(@"C:\Users\Ronan\source\repos\search-dotnet-asp-net-mvc-jobs-master\NYCJobsWeb\Schema_and_Data\allcontacts4.json");
            String batch5 = File.ReadAllText(@"C:\Users\Ronan\source\repos\search-dotnet-asp-net-mvc-jobs-master\NYCJobsWeb\Schema_and_Data\allcontacts5.json");
            String batch6 = File.ReadAllText(@"C:\Users\Ronan\source\repos\search-dotnet-asp-net-mvc-jobs-master\NYCJobsWeb\Schema_and_Data\allcontacts6.json");


            batch1 = batch1.Replace("company.id", "@company.id");
            batch2 = batch2.Replace("company.id", "@company.id");
            batch3 = batch3.Replace("company.id", "@company.id");
            batch4 = batch4.Replace("company.id", "@company.id");
            batch5 = batch5.Replace("company.id", "@company.id");
            batch6 = batch6.Replace("company.id", "@company.id");

            batch1 = batch1.Replace("gender.id", "@gender.id");
            batch2 = batch2.Replace("gender.id", "@gender.id");
            batch3 = batch3.Replace("gender.id", "@gender.id");
            batch4 = batch4.Replace("gender.id", "@gender.id");
            batch5 = batch5.Replace("gender.id", "@gender.id");
            batch6 = batch6.Replace("gender.id", "@gender.id");

            batch1 = batch1.Replace("businessUnit.id", "@businessUnit.id");
            batch2 = batch2.Replace("businessUnit.id", "@businessUnit.id");
            batch1 = batch3.Replace("businessUnit.id", "@businessUnit.id");
            batch2 = batch4.Replace("businessUnit.id", "@businessUnit.id");
            batch1 = batch5.Replace("businessUnit.id", "@businessUnit.id");
            batch2 = batch6.Replace("businessUnit.id", "@businessUnit.id");


            batch1 = batch1.Replace("contact.id", "@contact.id");
            batch2 = batch2.Replace("contact.id", "@contact.id");
            batch3 = batch3.Replace("contact.id", "@contact.id");
            batch4 = batch4.Replace("contact.id", "@contact.id");
            batch5 = batch5.Replace("contact.id", "@contact.id");
            batch6 = batch6.Replace("contact.id", "@contact.id");

            batch1 = batch1.Replace("language.id", "@language.id");
            batch2 = batch2.Replace("language.id", "@language.id");
            batch3 = batch3.Replace("language.id", "@language.id");
            batch4 = batch4.Replace("language.id", "@language.id");
            batch5 = batch5.Replace("language.id", "@language.id");
            batch6 = batch6.Replace("language.id", "@language.id");

            batch1 = batch1.Replace("client.id", "@client.id");
            batch2 = batch2.Replace("client.id", "@client.id");
            batch3 = batch3.Replace("client.id", "@client.id");
            batch4 = batch4.Replace("client.id", "@client.id");
            batch5 = batch5.Replace("client.id", "@client.id");
            batch6 = batch6.Replace("client.id", "@client.id");

            batch1 = batch1.Replace("customer.id", "@customer.id");
            batch2 = batch2.Replace("customer.id", "@customer.id");
            batch3 = batch3.Replace("customer.id", "@customer.id");
            batch4 = batch4.Replace("customer.id", "@customer.id");
            batch5 = batch5.Replace("customer.id", "@customer.id");
            batch6 = batch6.Replace("customer.id", "@customer.id");

            batch1 = batch1.Replace("customerBilling.id", "@customerBilling.id");
            batch2 = batch2.Replace("customerBilling.id", "@customerBilling.id");
            batch3 = batch3.Replace("customerBilling.id", "@customerBilling.id");
            batch4 = batch4.Replace("customerBilling.id", "@customerBilling.id");
            batch5 = batch5.Replace("customerBilling.id", "@customerBilling.id");
            batch6 = batch6.Replace("customerBilling.id", "@customerBilling.id");

            batch1 = batch1.Replace("type.id", "@type.id");
            batch2 = batch2.Replace("type.id", "@type.id");
            batch3 = batch3.Replace("type.id", "@type.id");
            batch4 = batch4.Replace("type.id", "@type.id");
            batch5 = batch5.Replace("type.id", "@type.id");
            batch6 = batch6.Replace("type.id", "@type.id");

            batch1 = batch1.Replace("parent.id", "@parent.id");
            batch2 = batch2.Replace("parent.id", "@parent.id");
            batch3 = batch3.Replace("parent.id", "@parent.id");
            batch4 = batch4.Replace("parent.id", "@parent.id");
            batch5 = batch5.Replace("parent.id", "@parent.id");
            batch6 = batch6.Replace("parent.id", "@parent.id");

            batch1 = batch1.Replace("region.id", "@region.id");
            batch2 = batch2.Replace("region.id", "@region.id");
            batch3 = batch3.Replace("region.id", "@region.id");
            batch4 = batch4.Replace("region.id", "@region.id");
            batch5 = batch5.Replace("region.id", "@region.id");
            batch6 = batch6.Replace("region.id", "@region.id");

            batch1 = batch1.Replace("billingRegion.id", "@billingRegion.id");
            batch2 = batch2.Replace("billingRegion.id", "@billingRegion.id");
            batch3 = batch3.Replace("billingRegion.id", "@billingRegion.id");
            batch4 = batch4.Replace("billingRegion.id", "@billingRegion.id");
            batch5 = batch5.Replace("billingRegion.id", "@billingRegion.id");
            batch6 = batch6.Replace("billingRegion.id", "@billingRegion.id");

            batch1 = batch1.Replace("client.id", "@client.id");
            batch2 = batch2.Replace("client.id", "@client.id");
            batch3 = batch3.Replace("client.id", "@client.id");
            batch4 = batch4.Replace("client.id", "@client.id");
            batch5 = batch5.Replace("client.id", "@client.id");
            batch6 = batch6.Replace("client.id", "@client.id");

            batch1 = batch1.Replace("parent.label", "@parent.label");
            batch2 = batch2.Replace("parent.label", "@parent.label");
            batch3 = batch3.Replace("parent.label", "@parent.label");
            batch4 = batch4.Replace("parent.label", "@parent.label");
            batch5 = batch5.Replace("parent.label", "@parent.label");
            batch6 = batch6.Replace("parent.label", "@parent.label");

            batch1 = batch1.Replace("criteria.id", "@criteria.id");
            batch2 = batch2.Replace("criteria.id", "@criteria.id");
            batch3 = batch3.Replace("criteria.id", "@criteria.id");
            batch4 = batch4.Replace("criteria.id", "@criteria.id");
            batch5 = batch5.Replace("criteria.id", "@criteria.id");
            batch6 = batch6.Replace("criteria.id", "@criteria.id");

            batch1 = batch1.Replace("eft.id", "@eft.id");
            batch2 = batch2.Replace("eft.id", "@eft.id");
            batch3 = batch3.Replace("eft.id", "@eft.id");
            batch4 = batch4.Replace("eft.id", "@eft.id");
            batch5 = batch5.Replace("eft.id", "@eft.id");
            batch6 = batch6.Replace("eft.id", "@eft.id");

            batch1 = batch1.Replace("eft.name", "@eft.name");
            batch2 = batch2.Replace("eft.name", "@eft.name");
            batch3 = batch3.Replace("eft.name", "@eft.name");
            batch4 = batch4.Replace("eft.name", "@eft.name");
            batch5 = batch5.Replace("eft.name", "@eft.name");
            batch6 = batch6.Replace("eft.name", "@eft.name");

            batch1 = batch1.Replace("paymentMethod.id", "@paymentMethod.id");
            batch2 = batch2.Replace("paymentMethod.id", "@paymentMethod.id");
            batch3 = batch3.Replace("paymentMethod.id", "@paymentMethod.id");
            batch4 = batch4.Replace("paymentMethod.id", "@paymentMethod.id");
            batch5 = batch5.Replace("paymentMethod.id", "@paymentMethod.id");
            batch6 = batch6.Replace("paymentMethod.id", "@paymentMethod.id");

            batch1 = batch1.Replace("paymentMethod.name", "@paymentMethod.name");
            batch2 = batch2.Replace("paymentMethod.name", "@paymentMethod.name");
            batch3 = batch3.Replace("paymentMethod.name", "@paymentMethod.name");
            batch4 = batch4.Replace("paymentMethod.name", "@paymentMethod.name");
            batch5 = batch5.Replace("paymentMethod.name", "@paymentMethod.name");
            batch6 = batch6.Replace("paymentMethod.name", "@paymentMethod.name");

            batch1 = batch1.Replace("employmentCategory.id", "@employmentCategory.id");
            batch2 = batch2.Replace("employmentCategory.id", "@employmentCategory.id");
            batch3 = batch3.Replace("employmentCategory.id", "@employmentCategory.id");
            batch4 = batch4.Replace("employmentCategory.id", "@employmentCategory.id");
            batch5 = batch5.Replace("employmentCategory.id", "@employmentCategory.id");
            batch6 = batch6.Replace("employmentCategory.id", "@employmentCategory.id");

            batch1 = batch1.Replace("assignmentTier.id", "@assignmentTier.id");
            batch2 = batch2.Replace("assignmentTier.id", "@assignmentTier.id");
            batch3 = batch3.Replace("assignmentTier.id", "@assignmentTier.id");
            batch4 = batch4.Replace("assignmentTier.id", "@assignmentTier.id");
            batch5 = batch5.Replace("assignmentTier.id", "@assignmentTier.id");
            batch6 = batch6.Replace("assignmentTier.id", "@assignmentTier.id");

            batch1 = batch1.Replace("currencyCode.id", "@currencyCode.id");
            batch2 = batch2.Replace("currencyCode.id", "@currencyCode.id");
            batch3 = batch3.Replace("currencyCode.id", "@currencyCode.id");
            batch4 = batch4.Replace("currencyCode.id", "@currencyCode.id");
            batch5 = batch5.Replace("currencyCode.id", "@currencyCode.id");
            batch6 = batch6.Replace("currencyCode.id", "@currencyCode.id");

            batch1 = batch1.Replace("type.nameKey", "@type.nameKey");
            batch2 = batch2.Replace("type.nameKey", "@type.nameKey");
            batch3 = batch3.Replace("type.nameKey", "@type.nameKey");
            batch4 = batch4.Replace("type.nameKey", "@type.nameKey");
            batch5 = batch5.Replace("type.nameKey", "@type.nameKey");
            batch6 = batch6.Replace("type.nameKey", "@type.nameKey");

            batch1 = batch1.Replace("values", "value");
            batch2 = batch2.Replace("values", "value");
            batch3 = batch3.Replace("values", "value");
            batch4 = batch4.Replace("values", "value");
            batch5 = batch5.Replace("values", "value");
            batch6 = batch6.Replace("values", "value");




            File.WriteAllText(@"C:\Users\Ronan\source\repos\search-dotnet-asp-net-mvc-jobs-master\NYCJobsWeb\Schema_and_Data\allcontacts1.json", batch1);
            File.WriteAllText(@"C:\Users\Ronan\source\repos\search-dotnet-asp-net-mvc-jobs-master\NYCJobsWeb\Schema_and_Data\allcontacts2.json", batch2);
            File.WriteAllText(@"C:\Users\Ronan\source\repos\search-dotnet-asp-net-mvc-jobs-master\NYCJobsWeb\Schema_and_Data\allcontacts3.json", batch3);
            File.WriteAllText(@"C:\Users\Ronan\source\repos\search-dotnet-asp-net-mvc-jobs-master\NYCJobsWeb\Schema_and_Data\allcontacts4.json", batch4);
            File.WriteAllText(@"C:\Users\Ronan\source\repos\search-dotnet-asp-net-mvc-jobs-master\NYCJobsWeb\Schema_and_Data\allcontacts5.json", batch5);
            File.WriteAllText(@"C:\Users\Ronan\source\repos\search-dotnet-asp-net-mvc-jobs-master\NYCJobsWeb\Schema_and_Data\allcontacts6.json", batch6);




        }
    }
}
