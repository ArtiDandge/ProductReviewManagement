using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Project");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ ProductID = 1, UserID = 1, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 2, UserID = 2, Rating = 8, Review = "Nice", isLike = true},
                new ProductReview(){ ProductID = 3, UserID = 3, Rating = 4, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 4, UserID = 4, Rating = 1, Review = "Not Good", isLike = false},
                new ProductReview(){ ProductID = 5, UserID = 5, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 6, UserID = 6, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 7, UserID = 7, Rating = 8, Review = "Nice", isLike = true},
                new ProductReview(){ ProductID = 8, UserID = 8, Rating = 7, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 9, UserID = 9, Rating = 10, Review = "Nice", isLike = true},
                new ProductReview(){ ProductID = 10, UserID = 10, Rating = 4.7, Review = "Good", isLike=true },
                new ProductReview(){ ProductID = 10, UserID = 11, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 12, UserID = 12, Rating = 5.6, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 12, UserID = 13, Rating = 4, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 14, UserID = 14, Rating = 2, Review = "Not Good", isLike = false},
                new ProductReview(){ ProductID = 14, UserID = 15, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 16, UserID = 16, Rating = 2.5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 17, UserID = 17, Rating = 9, Review = "Nice", isLike = true},
                new ProductReview(){ ProductID = 18, UserID = 18, Rating = 7, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 19, UserID = 19, Rating = 10, Review = "Nice", isLike = true},
                new ProductReview(){ ProductID = 20, UserID = 20, Rating = 5, Review = "Good", isLike=true },
                new ProductReview(){ ProductID = 21, UserID = 21, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 22, UserID = 22, Rating = 1.3, Review = "Not Good", isLike = false},
                new ProductReview(){ ProductID = 22, UserID = 23, Rating = 4, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 24, UserID = 24, Rating = 2, Review = "Not Good", isLike = false},
                new ProductReview(){ ProductID = 25, UserID = 25, Rating = 9, Review = "Nice", isLike = true},
            };

            foreach (var list in productReviewList)
            {
                Console.WriteLine("\n-----------------");
                Console.Write("\nProductID " + list.ProductID + "\nUserID " + list.UserID + "\nRating " + list.Rating + "\nReview " + list.Review + "\nisLike " + list.isLike);
                Console.WriteLine("\n-----------------");
            }

            ProductReviewManagement management = new ProductReviewManagement();
            management.TopRecords(productReviewList);
            management.SelectedRecords(productReviewList);
            management.RetrieveCountOfRecords(productReviewList);
            management.RetrieveProductIDAndReviewFromList(productReviewList);
            management.DisplayUnskippedRecords(productReviewList);

            Console.WriteLine("\n*****************************DataTable Operations*************************");
            ProductReviewDataTable reviewDataTable = new ProductReviewDataTable();
            DataTable table = reviewDataTable.CreateDataBleAndAddDefaultValues();
            reviewDataTable.DisplayDataTableRecordsWithIsLikeValueTrue(table);
            reviewDataTable.FindAverageRatingOfEachProductID(table);
            reviewDataTable.RetrievRecordsWhoseReviewIsNice(table);
            reviewDataTable.RetrievRecordsOfPerticularUserID(table);
        }
    }
}
