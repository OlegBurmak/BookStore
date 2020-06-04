using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TheBookStore.Models
{
    public class Comment
    {
        [BindNever]
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}