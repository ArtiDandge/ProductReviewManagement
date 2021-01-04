using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    public class ProductReviewManagement
    {
        /// <summary>
        /// Method to Retrieve Top 3 Records with high rating
        /// </summary>
        /// <param name="listProductReview">listProductReview</param>
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              orderby productReviews.Rating descending
                              select productReviews).Take(3).ToList();
            Console.WriteLine("Following are the records with top rating");
            DisplayRecords(recordData);
        }

        /// <summary>
        /// Method to Display records from list
        /// </summary>
        /// <param name="records">records of list</param>
        public void DisplayRecords(List<ProductReview> records)
        {
            foreach (var list in records)
            {
                Console.WriteLine("\n-----------------");
                Console.Write("\nProductID " + list.ProductID + "\nUserID " + list.UserID + "\nRating " + list.Rating + "\nReview " + list.Review + "\nisLike " + list.isLike);
                Console.WriteLine("\n-----------------");
            }
        }
    }
}
