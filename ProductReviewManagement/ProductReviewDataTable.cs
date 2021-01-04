﻿using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagement
{
    public class ProductReviewDataTable
    {
        /// <summary>
        /// Method To Create Data Table and add default values for it 
        /// </summary>
        public void CreateDataBleAndAddDefaultValues()
        {
            DataTable table = new DataTable();
            table.Columns.AddRange( new[]
                {
                    new DataColumn("ProductID", typeof(int)),
                    new DataColumn("UserID", typeof(int)),
                    new DataColumn("Rating", typeof(float)),
                    new DataColumn("Review",typeof(string)),
                    new DataColumn("isLike", typeof(bool))
                }            
            );
            table.Rows.Add(1, 1, 5, "Good", true);
            table.Rows.Add(2, 2, 8, "Nice", true);
            table.Rows.Add(3, 3, 4, "Good", true);
            table.Rows.Add(4, 4, 1, "Not Good", false);
            table.Rows.Add(5, 5, 5, "Good", true);
            table.Rows.Add(6, 6, 5.4, "Good", true);
            table.Rows.Add(7, 7, 8, "Nice", true);
            table.Rows.Add(8, 8, 7, "Good", true);
            table.Rows.Add(9, 9, 10, "Nice", true);
            table.Rows.Add(10, 10, 4.7, "Good", true);
            table.Rows.Add(11, 12, 5.6, "Good", true);
            table.Rows.Add(12, 13, 4, "Good", true);
            table.Rows.Add(13, 14, 2, "Not Good", false);
            table.Rows.Add(14, 15, 5, "Good", true);
            table.Rows.Add(15, 16, 2.5, "Good", true);
            table.Rows.Add(16, 17, 9, "Nice", true);
            table.Rows.Add(17, 18, 7, "Good", true);
            table.Rows.Add(18, 19, 10, "Nice", true);
            table.Rows.Add(19, 20, 5, "Good", true);
            table.Rows.Add(20, 21, 5, "Good", true);
            table.Rows.Add(21, 22, 1.3, "Not Good", false);
            table.Rows.Add(22, 23, 4, "Good", true);
            table.Rows.Add(23, 24, 2, "Not Good", false);
            table.Rows.Add(24, 24, 9, "Nice", true);
            table.Rows.Add(25, 25, 7, "Nice", true);
            Console.WriteLine("Following is list of Records who's isLike value is 'true'");
            DisplayDataTableRecords(table);
        }
   
        public void DisplayDataTableRecords(DataTable table)
        {
            var records = table.Rows.Cast<DataRow>()
                          .Where(x => x["isLike"].Equals(true));
            foreach (DataRow row in records)
            {
                Console.WriteLine("\n-----------------");
                Console.Write("\nProductID : " + row.Field<int>("ProductID")+" "+ "\nUserID : " + row.Field<int>("UserID") + " "+ "\nRating : " + row.Field<float>("Rating") + " "+ "\nReview : " + row.Field<string>("Review") + " "+ "\nisLike : "+ row.Field<bool>("isLike") + " ");
                Console.WriteLine("\n-----------------");
            }
        }
    }
}