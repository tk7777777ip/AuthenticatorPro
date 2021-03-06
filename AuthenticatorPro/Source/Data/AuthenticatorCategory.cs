﻿using SQLite;

namespace AuthenticatorPro.Data
{
    [Table("authenticatorcategory")]
    internal class AuthenticatorCategory
    {
        public AuthenticatorCategory()
        {
            Ranking = 1;
        }

        public AuthenticatorCategory(string categoryId, string authenticatorSecret)
        {
            CategoryId = categoryId;
            AuthenticatorSecret = authenticatorSecret;
            Ranking = 1;
        }

        [Column("categoryId")] [Indexed] public string CategoryId { get; set; }

        [Column("authenticatorSecret")]
        [Indexed]
        public string AuthenticatorSecret { get; set; }

        [Column("ranking")] public int Ranking { get; set; }
    }
}