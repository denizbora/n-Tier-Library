using System;
using System.Collections.Generic;
using Library.Core.Concrete;
using Library.DataAccess.Abstract;
using Microsoft.Data.SqlClient;

namespace Library.DataAccess.Concrete.ADONET
{
    public class ADOCategoryDal:IADORepository<Category>
    {
        public void Add(Category entity)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Categories VALUES (@CategoryName)"))
            {
                cmd.Parameters.AddWithValue("CategoryName", entity.CategoryName);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public void Update(Category entity)
        {
            using (SqlCommand cmd =
                new SqlCommand("UPDATE Categories set CategoryId = @CategoryId, CategoryName = @CategoryName,  where CategoryId = @CategoryId"))
            {
                cmd.Parameters.AddWithValue("CategoryId", entity.CategoryId);
                cmd.Parameters.AddWithValue("CategoryName", entity.CategoryName);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public void Delete(Category entity)
        {
            using (SqlCommand cmd =
                new SqlCommand("DELETE FROM Categories where CategoryId = @CategoryId"))
            {
                cmd.Parameters.AddWithValue("Id", entity.CategoryId);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public List<Category> GetAll()
        {
            var categoryList = new List<Category>();
            SqlCommand cmd = new SqlCommand("Select * from Categories");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Category category = new Category()
                {
                    CategoryId = Convert.ToInt32(reader[0]),
                    CategoryName = reader[1].ToString(),
                };

                categoryList.Add(category);
            }
            return categoryList;
        }

        public Category Get(int id)
        {
            SqlCommand cmd = new SqlCommand("Select * from Categories where Id = @CategoryId");
            cmd.Parameters.AddWithValue("CategoryId", id);

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Category category = new Category()
                {
                    CategoryId = Convert.ToInt32(reader[0]),
                    CategoryName = reader[1].ToString(),
                };

                return category;
            }
            return null;
        }
    }
}
