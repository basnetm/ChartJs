using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChartPractise.Models
{
    public class MyModel
    {
        //contructor
        public MyModel()
        {
            MyTransactions = new List<MyModel>();
        }

        public int Id { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }

        public List<MyModel> MyTransactions { get; set; }
    }
}