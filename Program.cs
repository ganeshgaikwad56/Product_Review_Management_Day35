
using System;
using System.Collections.Generic;
namespace ProductReviewManagementWithLinq
{
    class Program
    {
        /// <summary>
        /// UC1-Completed
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //greeting message
            Console.WriteLine("Welcome to the project review management");

            //Uc1
            List<ProductReview> listProductReview = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserId = 11, Rating = 3, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 2, UserId = 15, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 3, UserId = 1, Rating = 4, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 4, UserId = 9, Rating = 2, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 5, UserId = 2, Rating = 3, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 6, UserId = 5, Rating = 3, Review = "Bad", IsLike = false },
                new ProductReview() { ProductID = 7, UserId = 2, Rating = 1, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 8, UserId = 4, Rating = 1, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 9, UserId = 8, Rating = 5, Review = "bad", IsLike = false },
                new ProductReview() { ProductID = 10, UserId = 3, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 11, UserId = 7, Rating = 3, Review = "bad", IsLike = false },
                new ProductReview() { ProductID = 12, UserId = 13, Rating = 2, Review = "Good", IsLike = true }, 
                new ProductReview() { ProductID = 13, UserId = 17, Rating = 1, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 14, UserId = 15, Rating = 5, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 15, UserId = 19, Rating = 4, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 16, UserId = 20, Rating = 2, Review = "bad", IsLike = false },
                new ProductReview() { ProductID = 17, UserId = 18, Rating = 1, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 18, UserId = 12, Rating = 3, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 19, UserId = 10, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 20, UserId = 17, Rating = 4, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 21, UserId = 25, Rating = 4, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 22, UserId = 24, Rating = 5, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 23, UserId = 23, Rating = 4, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 24, UserId = 22, Rating = 5, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 25, UserId = 21, Rating = 4, Review = "Good", IsLike = false },

            };
            //foreach (var list in listProductReview)
            //{
            //    Console.WriteLine("ProductID:" + list.ProductID + "UserId" + list.UserId + "Rating" + list.Rating + "Review" + list.Review + "IsLike" + list.IsLike);
            //}
            Management management = new Management();
            //management.TopRecordsList(listProductReview);
            //management.SelectedRecordList(listProductReview);
            management.CountOfRecords(listProductReview);
        }
    }
        
}   
