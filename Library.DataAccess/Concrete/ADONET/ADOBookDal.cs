﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Library.Core.Concrete;
using Library.DataAccess.Abstract;
using Microsoft.Data.SqlClient;

namespace Library.DataAccess.Concrete.ADONET
{
    public class ADOBookDal:IBookDal
    {
        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            var bookList = new List<Book>();
            SqlCommand cmd = new SqlCommand("Select * from Books");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Book book = new Book
                {
                    Id = Convert.ToInt32(reader[0]),
                    Title = reader[1].ToString(),
                    Description = reader[2].ToString(),
                    Year = int.Parse(reader[3].ToString()),
                    CategoryId = Convert.ToInt32(reader[4])
                };

                bookList.Add(book);
            }
            return bookList;
        }

        public Book Get(int id)
        {
            SqlCommand cmd = new SqlCommand("Select * from Books where Id = @Id");
            cmd.Parameters.AddWithValue("Id", id);

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Book book = new Book
                {
                    Id = Convert.ToInt32(reader[0]),
                    Title = reader[1].ToString(),
                    Description = reader[2].ToString(),
                    Year = int.Parse(reader[3].ToString()),
                    CategoryId = Convert.ToInt32(reader[4])
                };

                return book;
            }
            return null;
        }

        public void Add(Book entity)
        {
            using (SqlCommand cmd =
                new SqlCommand("INSERT INTO Books (Title,Description, Year, CategoryId) VALUES (@Title,@Description, @Year, @CategoryId)"))
            {
                cmd.Parameters.AddWithValue("Title", entity.Title);
                cmd.Parameters.AddWithValue("Description", entity.Description);
                cmd.Parameters.AddWithValue("Year", entity.Year);
                cmd.Parameters.AddWithValue("CategoryId", entity.CategoryId);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public void Update(Book entity)
        {
            using (SqlCommand cmd =
                new SqlCommand("UPDATE Books set Title = @Title, Description = @Description, Year = @Year, CategoryId = @CategoryId where Id = @Id"))
            {
                cmd.Parameters.AddWithValue("Id", entity.Id);
                cmd.Parameters.AddWithValue("Title", entity.Title);
                cmd.Parameters.AddWithValue("Description", entity.Description);
                cmd.Parameters.AddWithValue("Year", entity.Year);
                cmd.Parameters.AddWithValue("CategoryId", entity.CategoryId);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public void Delete(Book entity)
        {
            using (SqlCommand cmd =
                new SqlCommand("DELETE FROM Books where Id = @Id"))
            {
                cmd.Parameters.AddWithValue("Id", entity.Id);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }
    }
}
