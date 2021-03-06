﻿// --------------------RENTAL BIKE APP-----------------
//
//
// Copyright (c) Microsoft. All Rights Reserved.
// License under the Apache License, Version 2.0.
//
//   Su Huu Vu Quang
//   Pham Hong Phuc
//   Tran Minh Quang
//   Ngo Minh Quang
//
//
// ------------------------------------------------------

using RentalBikeApp.Entities.SQLEntities;
using static RentalBikeApp.Program;
using System;

namespace RentalBikeApp.Presentation
{
    /// <summary>
    /// provider to function and event to help user interact with station detail screen
    /// </summary>
    public partial class StationDetailForm : BaseForm
    {
        private Station station;

        /// <summary>
        /// contructor of StationDetailForm
        /// </summary>
        public StationDetailForm() : base()
        {
            InitializeComponent("StationDetailForm", "Station Detail");
            DrawStationDetail();
        }

        /// <summary>
        /// Fill station information in StationDetailForm
        /// </summary>
        /// <param name="station">The station is displayed</param>
        public void FillStationDetail(Station station)
        {
            this.station = station;
            nameTxt.Text = station.NameStation;
            addressTxt.Text = station.AddressStation;
            areaTxt.Text = station.AreaStaion.ToString();
            numberTxt.Text = station.NumberOfBike.ToString();
            distanceTxt.Text = "100 m";
            timeTxt.Text = "10 phút";
        }

        /// <summary>
        /// Handle click event HomePageBut
        /// </summary>
        /// <param name="sender">The object send event</param>
        /// <param name="e">An EventArgs</param>
        protected override void HomePageBut_Click(object sender, EventArgs e)
        {
            homePageForm.RenderStationList();
            homePageForm.Show(this);
            this.Hide();
        }

        /// <summary>
        /// Handle click event RentBikeBut
        /// </summary>
        /// <param name="sender">The object send event</param>
        /// <param name="e">An EventArgs</param>
        protected override void RentBikeBut_Click(object sender, EventArgs e)
        {
            rentBikeForm.DisplayRentbikeQrcode();
            rentBikeForm.Show(this, this);
            this.Hide();
        }

        /// <summary>
        /// Handle click event TandemBut, display the list of tandems in this station
        /// </summary>
        /// <param name="sender">The object send event</param>
        /// <param name="e">An EventArgs</param>
        private void TandemBut_Click(object sender, EventArgs e)
        {
            listBikeForm.FillListTandems(station.StationId, station.NameStation, station.AddressStation);
            listBikeForm.Show(this, this);
            this.Hide();
        }

        /// <summary>
        /// Handle click event ElectricBut, display the list of electric bikes in this station
        /// </summary>
        /// <param name="sender">The object send event</param>
        /// <param name="e">An EventArgs</param>
        private void ElectricBut_Click(object sender, EventArgs e)
        {
            listBikeForm.FillListElectric(station.StationId, station.NameStation, station.AddressStation);
            listBikeForm.Show(this, this);
            this.Hide();
        }

        /// <summary>
        /// Handle click event BikeBut, display list of normal bike in this station
        /// </summary>
        /// <param name="sender">The object send event</param>
        /// <param name="e">An EventArgs</param>
        private void BikeBut_Click(object sender, EventArgs e)
        {
            listBikeForm.FillListBikes(station.StationId, station.NameStation, station.AddressStation);
            listBikeForm.Show(this, this);
            this.Hide();
        }
    }
}
