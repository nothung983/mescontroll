using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MesControlApp
{
    internal class User_Image_Management
    {
        private static readonly string imageFolderPath = @"D:\NAM IV.NET\PROJECT\mescontroll\MesControlApp\MesControlApp\assets\users";

        // Save user image to database
        public static void SaveUserImage(int userID, byte[] image, string fileName)
        {
            try
            {
                // Ensure the directory exists
                if (!Directory.Exists(imageFolderPath))
                {
                    Directory.CreateDirectory(imageFolderPath);
                }

                // Save the image to the file system
                string filePath = Path.Combine(imageFolderPath, fileName);
                File.WriteAllBytes(filePath, image);

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "UPDATE Users SET User_Image = @Image WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@Image", fileName);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving user image: " + ex.Message);
            }
        }

        // Get user image from database
        public static byte[] GetUserImage(int userID)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT User_Image FROM Users WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        string fileName = (string)cmd.ExecuteScalar();
                        string filePath = Path.Combine(imageFolderPath, fileName);

                        if (File.Exists(filePath))
                        {
                            return File.ReadAllBytes(filePath);
                        }
                        else
                        {
                            throw new FileNotFoundException("User image not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting user image: " + ex.Message);
            }
        }

        // Delete user image from database
        public static void DeleteUserImage(int userID)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "UPDATE Users SET User_Image = NULL WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting user image: " + ex.Message);
            }
        }

        // Update user image in database
        public static void UpdateUserImage(int userID, byte[] image, string fileName)
        {
            try
            {
                // Ensure the directory exists
                if (!Directory.Exists(imageFolderPath))
                {
                    Directory.CreateDirectory(imageFolderPath);
                }
                // Save the image to the file system
                string filePath = Path.Combine(imageFolderPath, fileName);
                File.WriteAllBytes(filePath, image);
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "UPDATE Users SET User_Image = @Image WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@Image", fileName);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating user image: " + ex.Message);
            }
        }
    }
}
