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

            String batch1 = File.ReadAllText(@"C:\Users\Ronan\source\repos\GetAllContactsFromInterpreterIntelligence\GetAllContactsFromInterpreterIntelligence\contactsBatch1.json");
            String batch2 = File.ReadAllText(@"C:\Users\Ronan\source\repos\GetAllContactsFromInterpreterIntelligence\GetAllContactsFromInterpreterIntelligence\contactsBatch2.json");
            String batch3 = File.ReadAllText(@"C:\Users\Ronan\source\repos\GetAllContactsFromInterpreterIntelligence\GetAllContactsFromInterpreterIntelligence\contactsBatch3.json");
            String batch4 = File.ReadAllText(@"C:\Users\Ronan\source\repos\GetAllContactsFromInterpreterIntelligence\GetAllContactsFromInterpreterIntelligence\contactsBatch4.json");
            String batch5 = File.ReadAllText(@"C:\Users\Ronan\source\repos\GetAllContactsFromInterpreterIntelligence\GetAllContactsFromInterpreterIntelligence\contactsBatch5.json");

            batch1 = batch1.Replace("company.id", "companyId");
            batch1 = batch1.Replace("gender.id", "genderId");
            batch1 = batch1.Replace("businessUnit.id", "businessUnitId");
            batch1 = batch1.Replace("language.id", "languageId");
            batch1 = batch1.Replace("currencyCode.id", "currencyCodeId");
            batch1 = batch1.Replace("eft.id", "eftId");
            batch1 = batch1.Replace("eft.name", "eftName");
            batch1 = batch1.Replace("paymentMehod.id", "paymentMethodId");
            batch1 = batch1.Replace("paymentMethod.name", "paymentMethodName");
            batch1 = batch1.Replace("employmentCategory.id", "employmentCategoryId");
            batch1 = batch1.Replace("assignmentTier.id", "assignmentTierId");



            batch2 = batch2.Replace("company.id", "companyId");
            batch2 = batch2.Replace("gender.id", "genderId");
            batch2 = batch2.Replace("businessUnit.id", "businessUnitId");
            batch2 = batch2.Replace("language.id", "languageId");
            batch2 = batch2.Replace("currencyCode.id", "currencyCodeId");
            batch2 = batch2.Replace("eft.id", "eftId");
            batch2 = batch2.Replace("eft.name", "eftName");
            batch2 = batch2.Replace("paymentMehod.id", "paymentMethodId");
            batch2 = batch2.Replace("paymentMethod.name", "paymentMethodName");
            batch2 = batch2.Replace("employmentCategory.id", "employmentCategoryId");
            batch2 = batch2.Replace("assignmentTier.id", "assignmentTierId");

            batch3 = batch3.Replace("company.id", "companyId");
            batch3 = batch3.Replace("gender.id", "genderId");
            batch3 = batch3.Replace("businessUnit.id", "businessUnitId");
            batch3 = batch3.Replace("language.id", "languageId");
            batch3 = batch3.Replace("currencyCode.id", "currencyCodeId");
            batch3 = batch3.Replace("eft.id", "eftId");
            batch3 = batch3.Replace("eft.name", "eftName");
            batch3 = batch3.Replace("paymentMehod.id", "paymentMethodId");
            batch3 = batch3.Replace("paymentMethod.name", "paymentMethodName");
            batch3 = batch3.Replace("employmentCategory.id", "employmentCategoryId");
            batch3 = batch3.Replace("assignmentTier.id", "assignmentTierId");

            batch4 = batch4.Replace("company.id", "companyId");
            batch4 = batch4.Replace("gender.id", "genderId");
            batch4 = batch4.Replace("businessUnit.id", "businessUnitId");
            batch4 = batch4.Replace("language.id", "languageId");
            batch4 = batch4.Replace("currencyCode.id", "currencyCodeId");
            batch4 = batch4.Replace("eft.id", "eftId");
            batch4 = batch4.Replace("eft.name", "eftName");
            batch4 = batch4.Replace("paymentMehod.id", "paymentMethodId");
            batch4 = batch4.Replace("paymentMethod.name", "paymentMethodName");
            batch4 = batch4.Replace("employmentCategory.id", "employmentCategoryId");
            batch4 = batch4.Replace("assignmentTier.id", "assignmentTierId");

            batch5 = batch5.Replace("company.id", "companyId");
            batch5 = batch5.Replace("gender.id", "genderId");
            batch5 = batch5.Replace("businessUnit.id", "businessUnitId");
            batch5 = batch5.Replace("language.id", "languageId");
            batch5 = batch5.Replace("currencyCode.id", "currencyCodeId");
            batch5 = batch5.Replace("eft.id", "eftId");
            batch5 = batch5.Replace("eft.name", "eftName");
            batch5 = batch5.Replace("paymentMehod.id", "paymentMethodId");
            batch5 = batch5.Replace("paymentMethod.name", "paymentMethodName");
            batch5 = batch5.Replace("employmentCategory.id", "employmentCategoryId");
            batch5 = batch5.Replace("assignmentTier.id", "assignmentTierId");

            File.WriteAllText(@"C:\Users\Ronan\source\repos\GetAllContactsFromInterpreterIntelligence\GetAllContactsFromInterpreterIntelligence\contactsBatch1.json", batch1);
            File.WriteAllText(@"C:\Users\Ronan\source\repos\GetAllContactsFromInterpreterIntelligence\GetAllContactsFromInterpreterIntelligence\contactsBatch2.json", batch2);
            File.WriteAllText(@"C:\Users\Ronan\source\repos\GetAllContactsFromInterpreterIntelligence\GetAllContactsFromInterpreterIntelligence\contactsBatch3.json", batch3);
            File.WriteAllText(@"C:\Users\Ronan\source\repos\GetAllContactsFromInterpreterIntelligence\GetAllContactsFromInterpreterIntelligence\contactsBatch4.json", batch4);
            File.WriteAllText(@"C:\Users\Ronan\source\repos\GetAllContactsFromInterpreterIntelligence\GetAllContactsFromInterpreterIntelligence\contactsBatch5.json", batch5);


        }
    }
}
