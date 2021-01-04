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
            Console.WriteLine("\nFollowing are the records with top rating");
            DisplayRecords(recordData);
        }

        /// <summary>
        /// Method to retrieve all records from list who's rating are greater that 3 and Product ID 1, 4 and 9
        /// </summary>
        /// <param name="listProductReview"></param>
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              where ((productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                              && productReviews.Rating > 3)
                              select productReviews).ToList();
            Console.WriteLine("\nFollowing are the records with rating greater that 3 among Product ID 1, 4 and 9");
            DisplayRecords(recordData);
        }

        /// <summary>
        /// Retrieve count of review present fro each ProductID using GroupBy operator
        /// </summary>
        /// <param name="listProductReview">listProductReview</param>
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            Console.WriteLine("\nResult for Records Grouped By ProductID");
            foreach (var list in recordData)
            {
                Console.WriteLine("Product ID : "+list.ProductID + "\t------>\tCount : " + list.Count);
            }
            Console.WriteLine("\n******************************************************");
        }

        /// <summary>
        /// Method to retrieve only Product ID and Review of Product
        /// </summary>
        /// <param name="listProductReview">listProductReview</param>
        public void RetrieveProductIDAndReviewFromList(List<ProductReview> listProductReview)
        {
            var recordData = listProductReview.Select(x => new { ProductID = x.ProductID, ProductReview = x.Review});
            Console.WriteLine("\nFollowing is List of Product Id and its Review ");
            foreach (var records in recordData)
            {

                Console.WriteLine("ProductID : "+ records.ProductID + "\tProduct Review : "+records.ProductReview);
            }
            Console.WriteLine("\n******************************************************");
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
            Console.WriteLine("\n******************************************************");
        }
    }
}
