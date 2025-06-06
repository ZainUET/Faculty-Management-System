﻿using System;
using System.Data;
using System.Windows.Forms;
using DB_Mid_Project.DL; // Import the data layer

namespace DB_Mid_Project.UI
{
    public partial class ShowRooms : Form
    {
        public ShowRooms()
        {
            InitializeComponent();
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            try
            {
                DataTable dt = ShowRoomsDL.GetRooms();
                rooms.DataSource = dt;

                rooms.Columns["room_id"].HeaderText = "Room ID";
                rooms.Columns["room_name"].HeaderText = "Room Name";
                rooms.Columns["room_type"].HeaderText = "Room Type";
                rooms.Columns["capacity"].HeaderText = "Capacity";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RoomManagement showForm = new RoomManagement();
            this.Hide();
            showForm.ShowDialog();
            this.Close();
        }
    }
}
