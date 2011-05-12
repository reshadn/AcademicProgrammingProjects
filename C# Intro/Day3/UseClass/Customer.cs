using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseClass
{
    public class Customer
    {
        public string companyName;
        public string contactName;

        private decimal m_AnnualSales;
        private int m_CompanyNumber;
        private static int totalCompanies = 0; 
        /* static --> part of overall class
         * first time it's zero then increment based on method
         */ 

        public Customer() // null parameter list
            //constructor = method with no return data type
        {
            companyName = "Not assigned";
            m_AnnualSales = 0;
            contactName = "Not assigned";

            totalCompanies++;
            m_CompanyNumber = totalCompanies;
        }

        public Customer(string Name, decimal sales, string contactName) 
            /* constructor = method with no return data type
             * overloaded constructor
             */ 
        {
            companyName = Name;
            m_AnnualSales = sales;
            this.contactName = contactName;

            totalCompanies++;
            m_CompanyNumber = totalCompanies;
        }

        public decimal NewSales(decimal amount) // method returning decimal
        {
            if (amount >= 0)
            {
                return m_AnnualSales += amount;
            }
            else
            {
                return 0;
            }
        }

        public decimal AnnualSales // method returning decimal
        {
            get
            {
                return m_AnnualSales;
            }
            set
            {
                if (value >= 0)
                {
                    m_AnnualSales = value;
                }
                else
                {
                    m_AnnualSales = 0;
                }
            }
        }

        public int CompanyNumber // method returning integer
        {
            get
            {
                return m_CompanyNumber;
            }
        }

        public override string ToString() // "override ToString" redefines how ToString is printed
        {
            return "Customer Data: \n\t" +
                "Company Number: " + m_CompanyNumber + "\n\t" +
                "Company Name: " + companyName + "\n\t" +
                "Annual Sales: " + m_AnnualSales.ToString("C") + "\n\t" +
                "Contact Name: " + contactName + "\n\n\t\t" +
                "Total number of Companies: " + totalCompanies + "\n";
        }
    }
}
