using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductReviewManagementWithLinq
{
    public class Management
    {
        /// <summary>
        /// 
        /// UC_2 Completed
        /// </summary>
        /// <param name="reviews"></param>
        public void TopRecordsList(List<ProductReview> review)
        {
            var recordData = (from productreviews in review
                              orderby productreviews.Rating descending
                              select productreviews).Take(3);

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID:" + list.ProductID + "UserId : " + list.UserId  + " Rating : " + list.Rating  + " Review : " + list.Review + " IsLike : " + list.IsLike);
            }
        }
        public void SelectedRecordList(List<ProductReview> reviews)
        {
            var recordData = (from productreviews in reviews
                              where (productreviews.ProductID == 1 && productreviews.Rating > 3)
                              || (productreviews.ProductID == 4 && productreviews.Rating > 3)
                              || (productreviews.ProductID == 9 && productreviews.Rating > 3)
                              select productreviews);

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID:" + list.ProductID + "UserId : " + list.UserId + " Rating : " + list.Rating + " Review : " + list.Review + " IsLike : " + list.IsLike);
            }
        }

    }
}