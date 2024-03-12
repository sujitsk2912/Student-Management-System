using System;
using System.Data.SqlClient;
using System.Windows.Forms;

internal static class frmstudentHelpers
{

    public static string DetermineBatch(int studentID)
    {
        string batch = string.Empty; // Initialize to an empty string

        string connection = "Data Source=LAPTOP-CNVSH31R\\SQLEXPRESS01;Initial Catalog=sujitdb;Integrated Security=True";

        using (SqlConnection conn = new SqlConnection(connection))
        {
            try
            {
                conn.Open();

                string batchQuery = $"SELECT COURSE FROM Admission_DotNet_Java WHERE [STUDENT ID] = {studentID}";

                using (SqlCommand cmd = new SqlCommand(batchQuery, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            batch = reader["COURSE"].ToString();
                            // You might want to add additional checks or processing here if needed
                        }
                        else
                        {
                            MessageBox.Show($"Student with ID {studentID} not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        return batch; // Ensure to return a value
    }
}
