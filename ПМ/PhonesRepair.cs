﻿using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace ПМ
{
    public partial class PhonesRepair : Form
    {
        PostgresConnector bd = new PostgresConnector();

        public PhonesRepair()
        {
            InitializeComponent();
            UpdateDataGridView();

            comboBoxTypeOfOrders.Items.Add("Свободные заказы");
            comboBoxTypeOfOrders.Items.Add("В работе");
            comboBoxTypeOfOrders.Items.Add("Готовые заказы");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridViewRepair.DataSource;

            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        string updateString = "UPDATE client_info SET phone_name = @phone_name, problem = @problem, status = @status, master_fio = @master_fio, comments = @comments WHERE client_info_id = @client_info_id";
                        NpgsqlCommand cmd = new NpgsqlCommand(updateString, bd.getConnection());
                        cmd.Parameters.AddWithValue("@phone_name", row["phone_name"]);
                        cmd.Parameters.AddWithValue("@problem", row["problem"]);
                        cmd.Parameters.AddWithValue("@status", row["status"]);
                        cmd.Parameters.AddWithValue("master_fio", row["master_fio"]);
                        cmd.Parameters.AddWithValue("@client_info_id", row["client_info_id"]);
                        cmd.Parameters.AddWithValue("@comments", row["comments"]);
                        bd.openConnection();
                        cmd.ExecuteNonQuery();
                        bd.closeConnection();
                    }
                }
            }

            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            string selectedValue = comboBoxTypeOfOrders.SelectedItem?.ToString();

            string query;
            if (selectedValue != null)
            {
                if (selectedValue == "Свободные заказы")
                {
                    query = @"SELECT client_info_id, phone_name, problem, master_fio, status, comments FROM client_info
                            WHERE status IS NULL
                            ORDER BY
                            CASE
                                WHEN status = 'Свободные заказы' THEN 1
                                WHEN status = 'В работе' THEN 2
                                WHEN status = 'Готовые заказы' THEN 3
                            END;";
                }
                else if (selectedValue == "Готовые заказы")
                {
                    query = @"
                SELECT client_info_id, phone_name, problem, master_fio, status, comments FROM client_info
                WHERE status = 'Готов'
                ORDER BY
                    CASE
                        WHEN status = 'Свободные заказы' THEN 1
                        WHEN status = 'В работе' THEN 2
                        WHEN status = 'Готовые заказы' THEN 3
                    END;
            ";
                }
                else
                {
                    query = @"
                SELECT client_info_id, phone_name, problem, master_fio, status, comments FROM client_info
                WHERE status = @status
                ORDER BY
                    CASE
                        WHEN status = 'Свободные заказы' THEN 1
                        WHEN status = 'В работе' THEN 2
                        WHEN status = 'Готовые заказы' THEN 3
                    END;
            ";
                }
            }
            else
            {
                query = "SELECT client_info_id, phone_name, problem, master_fio, status, comments FROM client_info";
            }

            using (NpgsqlCommand command = new NpgsqlCommand(query, bd.getConnection()))
            {
                if (selectedValue != null && selectedValue != "Свободные заказы" && selectedValue != "Готовые заказы")
                {
                    command.Parameters.AddWithValue("@status", selectedValue);
                }
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewRepair.DataSource = table;

                    dataGridViewRepair.Columns["client_info_id"].Visible = false;

                    dataGridViewRepair.Columns["phone_name"].HeaderText = "Название телефона";
                    dataGridViewRepair.Columns["problem"].HeaderText = "Проблема";
                    dataGridViewRepair.Columns["master_fio"].HeaderText = "ФИО мастера";
                    dataGridViewRepair.Columns["status"].HeaderText = "Статус";
                    dataGridViewRepair.Columns["comments"].HeaderText = "Комментарии";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f1 = new Menu();
            f1.ShowDialog();
        }

        private void PhonesRepair_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
