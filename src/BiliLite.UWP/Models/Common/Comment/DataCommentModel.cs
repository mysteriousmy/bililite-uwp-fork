﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using BiliLite.Controls;
using BiliLite.ViewModels.Comment;

namespace BiliLite.Models.Common.Comment
{
    public class DataCommentModel
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public DataCommentModel Data { get; set; }

        public DataCommentModel Page { get; set; }
        public int Acount { get; set; }
        public int Count { get; set; }
        public int Num { get; set; }
        public int Size { get; set; }

        public CommentCursor Cursor { get; set; }

        public List<CommentItem> Hots { get; set; }
        public List<CommentItem> Replies { get; set; }

        public DataCommentModel Upper { get; set; }
        public CommentViewModel Top { get; set; }
    }
}