﻿using Microsoft.AspNet.Identity.EntityFramework;
using myfoodapp.Hub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Web;

namespace myfoodapp.Hub.Migrations
{
    public static class UpgradeDatabase
    {

		public static void EventTypesIcons (ApplicationDbContext context)
		{
			var warning = context.EventTypes.FirstOrDefault(e => e.Id == 1);
			warning.svgPath= @"<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 40 40""><path id=""Path_73"" data-name=""Path 73"" class=""cls-1"" d=""M39.8,37.617,21.517.936A1.607,1.607,0,0,0,19.986,0a1.792,1.792,0,0,0-1.531.936L.168,37.617a1.581,1.581,0,0,0,.085,1.617A1.764,1.764,0,0,0,1.7,40H38.273a1.894,1.894,0,0,0,1.446-.766A1.581,1.581,0,0,0,39.8,37.617ZM21.687,31.745a1.7,1.7,0,1,1-3.4,0v-.6a1.7,1.7,0,1,1,3.4,0Zm0-6.638a1.7,1.7,0,1,1-3.4,0V16.255a1.7,1.7,0,1,1,3.4,0Z"" transform=""translate(0.014)""/></svg>";
			var issue = context.EventTypes.FirstOrDefault(e => e.Id == 2);
			issue.svgPath= @"<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 40 40""><path id=""_27_Question"" data-name=""27 Question"" class=""cls-1"" d=""M20,0A20,20,0,1,0,34.507,33.768,19.752,19.752,0,0,0,40,20,20,20,0,0,0,20,0Zm0,31.667A1.667,1.667,0,1,1,21.667,30,1.667,1.667,0,0,1,20,31.667ZM22.625,22a1.417,1.417,0,0,0-.958,1.267v.9a1.667,1.667,0,0,1-3.333,0v-.9A4.733,4.733,0,0,1,21.392,18.9a3.725,3.725,0,0,0,2.358-3.542,3.817,3.817,0,0,0-3.7-3.692,3.667,3.667,0,0,0-2.683,1.083,3.733,3.733,0,0,0-1.117,2.667,1.667,1.667,0,0,1-3.333,0A7.083,7.083,0,0,1,20,8.333h.1A7.083,7.083,0,0,1,22.6,22Z""/></svg>";
			var meintenance = context.EventTypes.FirstOrDefault(e => e.Id == 3);
			meintenance.svgPath = @"<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 40 40""><path id=""Path_72"" data-name=""Path 72"" class=""cls-1"" d=""M39.138,7.034a1.92,1.92,0,0,0-1.191-1.1,1.936,1.936,0,0,0-1.531.425l-3.573,3.652L30.034,7.119l3.573-3.652a1.517,1.517,0,0,0,.425-1.529A1.45,1.45,0,0,0,32.927.749,16.374,16.374,0,0,0,27.907-.1,9.852,9.852,0,0,0,20.76,2.533c-2.3,2.378-2.3,6.285-2.212,9l-6.721,6.794c-.51,0-1.106-.085-1.787-.085-3.318,0-5.615.764-7.147,2.293C-.34,23.764-.51,28.775.681,32.257a1.92,1.92,0,0,0,1.191,1.1A1.67,1.67,0,0,0,3.4,32.936l2.978-3.057,3.4,3.4L6.807,36.333a1.517,1.517,0,0,0-.425,1.529,1.45,1.45,0,0,0,1.106,1.189,14.5,14.5,0,0,0,5.02.849h0a9.852,9.852,0,0,0,7.147-2.633c2.3-2.293,2.382-5.86,2.127-9.257l6.381-6.454a17.118,17.118,0,0,0,2.127.085c3.233,0,5.53-.764,7.062-2.293C40.5,16.291,40.5,10.94,39.138,7.034Z"" transform=""translate(-0.003 0.1)""/></svg>";
			var action = context.EventTypes.FirstOrDefault(e => e.Id == 4);
			action.svgPath = @"<svg id=""Group_51"" data-name=""Group 51"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 40 38""><path id = ""Path_69"" data - name = ""Path 69"" class=""cls-1"" d=""M9.9,9.776a1.706,1.706,0,0,0,1.7-1.7V1.7a1.7,1.7,0,0,0-3.4,0V8.161A1.752,1.752,0,0,0,9.9,9.776Z"" transform=""translate(-1.221)""/><path id = ""Path_70"" data-name=""Path 70"" class=""cls-1"" d=""M36.5,9.776a1.706,1.706,0,0,0,1.7-1.7V1.7a1.7,1.7,0,0,0-3.4,0V8.161A1.691,1.691,0,0,0,36.5,9.776Z"" transform=""translate(-5.183)""/><path id = ""Path_71"" data-name=""Path 71"" class=""cls-1"" d=""M38.3,4.1H36.255V8.691a5.021,5.021,0,0,1-10.043,0V4.1H13.7V8.691a5.021,5.021,0,0,1-10.043,0V4.1H1.7A1.706,1.706,0,0,0,0,5.8V36.914a1.706,1.706,0,0,0,1.7,1.7H38.3a1.706,1.706,0,0,0,1.7-1.7V5.8A1.706,1.706,0,0,0,38.3,4.1ZM11.83,30.709a1.7,1.7,0,0,1-3.4,0v-.085a1.7,1.7,0,0,1,3.4,0Zm0-11.221a1.7,1.7,0,0,1-3.4,0v-.17a1.7,1.7,0,0,1,3.4,0ZM21.7,30.709a1.7,1.7,0,0,1-3.4,0v-.085a1.7,1.7,0,0,1,3.4,0Zm0-11.221a1.7,1.7,0,0,1-3.4,0v-.17a1.7,1.7,0,0,1,3.4,0Zm9.787,11.221a1.7,1.7,0,0,1-3.4,0v-.085a1.7,1.7,0,0,1,3.4,0Zm0-11.221a1.7,1.7,0,0,1-3.4,0v-.17a1.7,1.7,0,0,1,3.4,0Z"" transform=""translate(0 -0.615)""/></svg>";
			var plant_health = context.EventTypes.FirstOrDefault(e => e.Id == 5);
			plant_health.svgPath= @"<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 40 40""><path id=""Path_66"" data-name=""Path 66"" class=""cls-1"" d=""M39.5.511A1.681,1.681,0,0,0,38.31,0C37.289,0,13.367.681,5.961,8.085-1.19,15.319-1.956,26.383,4,33.617l8.768-8.766L14.048,12.6a1.626,1.626,0,0,1,3.235.34l-.851,8.17,3.49-3.489A1.685,1.685,0,1,1,22.306,20l-3.49,3.489,8.172-.851a1.626,1.626,0,1,1,.341,3.234L15.155,27.234,6.387,36a17.863,17.863,0,0,0,11.322,4,20.24,20.24,0,0,0,14.217-6.043C39.332,26.638,40.013,2.723,40.013,1.7A1.68,1.68,0,0,0,39.5.511Z"" transform=""translate(-0.013)""/></svg>";
			var fish_health = context.EventTypes.FirstOrDefault(e => e.Id == 6);
			fish_health.svgPath = @"<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 40 25""><g id=""Group_49"" data-name=""Group 49"" transform=""translate(0.075)""><path id=""Path_64"" data-name=""Path 64"" class=""cls-1"" d=""M41.069,1.842a1.645,1.645,0,0,0-1.881.7l-2.822,4.3C31.919,2.368,26.7,0,21.315,0a17.869,17.869,0,0,0-5.73.965c2.908,9.211.855,19.3-.086,23.07A18.8,18.8,0,0,0,21.315,25c5.387,0,10.6-2.368,14.965-6.754l2.822,4.3a1.672,1.672,0,0,0,3.079-.965V3.509A1.714,1.714,0,0,0,41.069,1.842Z"" transform=""translate(-2.256 0)""/><path id=""Path_65"" data-name=""Path 65"" class=""cls-1"" d=""M10.166,2.5a27.752,27.752,0,0,0-9.92,9.3,1.611,1.611,0,0,0,0,1.93,27.257,27.257,0,0,0,9.834,9.211,51.422,51.422,0,0,0,1.112-6.754v-8.6A26.839,26.839,0,0,0,10.166,2.5ZM6.83,14.518H6.317a1.755,1.755,0,0,1,0-3.509H6.83a1.755,1.755,0,0,1,0,3.509Z"" transform=""translate(0 -0.307)""/></g></svg>";
			var feeling = context.EventTypes.FirstOrDefault(e => e.Id == 7);
			feeling.svgPath = @"<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 40 40""><path id=""Path_78"" data-name=""Path 78"" class=""cls-1"" d=""M20,0A20,20,0,1,0,40,20,19.977,19.977,0,0,0,20,0Zm5.787,13.7a1.7,1.7,0,0,1,3.4,0v.17a1.7,1.7,0,0,1-3.4,0Zm-14.894,0a1.7,1.7,0,1,1,3.4,0v.17a1.7,1.7,0,0,1-3.4,0V13.7Zm19.4,11.83a14.588,14.588,0,0,1-20.6,0,1.685,1.685,0,1,1,2.383-2.383,11.3,11.3,0,0,0,16,0,1.645,1.645,0,0,1,2.383,0A1.823,1.823,0,0,1,30.3,25.532Z""/></svg>";
			var info = context.EventTypes.FirstOrDefault(e => e.Id == 8);
			info.svgPath = @"<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 40 40""><path id=""Path_74"" data-name=""Path 74"" class=""cls-1"" d=""M20,0A20,20,0,1,0,40,20,19.977,19.977,0,0,0,20,0ZM18.213,9.191a1.7,1.7,0,1,1,3.4,0v1.617a1.7,1.7,0,0,1-3.4,0Zm3.574,21.617a1.7,1.7,0,0,1-3.4,0V17.021a1.7,1.7,0,0,1,3.4,0Z""/></svg>";
			var advices = context.EventTypes.FirstOrDefault(e => e.Id == 9);
			advices.svgPath = @"<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 40 40""><path id=""Path_75"" data-name=""Path 75"" class=""cls-1"" d=""M35.177,0H4.74A4.661,4.661,0,0,0,0,4.593V25.052a4.608,4.608,0,0,0,4.74,4.593H20.79L30.52,39.5a1.639,1.639,0,0,0,1.164.5,1,1,0,0,0,.665-.167,1.529,1.529,0,0,0,1-1.5v-8.6H35.26A4.715,4.715,0,0,0,40,25.136V4.593A4.789,4.789,0,0,0,35.177,0ZM29.106,21.294h-18.3a1.67,1.67,0,0,1,0-3.34h18.3a1.67,1.67,0,0,1,0,3.34Zm0-9.687h-18.3a1.67,1.67,0,0,1,0-3.34h18.3a1.67,1.67,0,0,1,0,3.34Z""/></svg>";
			var improvement = context.EventTypes.FirstOrDefault(e => e.Id == 10);
			improvement.svgPath = @"<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 40 40""><g id=""Group_52"" data-name=""Group 52"" transform=""translate(0.038 0.038)""><path id=""Path_76"" data-name=""Path 76"" class=""cls-1"" d=""M38.655,26.159l-2.124-.931a17.277,17.277,0,0,0,.17-10.161l2.209-.847a1.636,1.636,0,1,0-1.19-3.048l-2.209.847a17.144,17.144,0,0,0-7.052-7.282l.85-2.2a1.707,1.707,0,0,0-.85-2.2,1.718,1.718,0,0,0-2.209.847l-.935,2.2a17.451,17.451,0,0,0-10.2-.169l-.85-2.2A1.64,1.64,0,0,0,11.21,2.2l.85,2.2a17.15,17.15,0,0,0-7.307,7.028l-2.209-.847a1.718,1.718,0,0,0-2.209.847,1.707,1.707,0,0,0,.85,2.2l2.209.931a17.277,17.277,0,0,0-.17,10.161l-2.209.847a1.623,1.623,0,0,0-.935,2.117,1.742,1.742,0,0,0,1.614,1.1,1.451,1.451,0,0,0,.595-.085L4.5,27.853a17.144,17.144,0,0,0,7.052,7.282l-.935,2.117a1.707,1.707,0,0,0,.85,2.2,2.005,2.005,0,0,0,.68.169,1.556,1.556,0,0,0,1.529-1.016l.935-2.2a16.83,16.83,0,0,0,5.353.847,19.089,19.089,0,0,0,4.843-.677l.85,2.2a1.556,1.556,0,0,0,1.529,1.016,1.451,1.451,0,0,0,.595-.085,1.623,1.623,0,0,0,.935-2.117l-.85-2.2h.085L24.89,32.426l-5.693.169h-.17a5.167,5.167,0,0,1-3.569-1.44l-5.268-5.25a4.945,4.945,0,0,1,0-7.028,5.018,5.018,0,0,1,3.569-1.44,5.167,5.167,0,0,1,3.569,1.44L21.067,22.6H22v-.931l-3.654-3.9a4.945,4.945,0,0,1,0-7.028,5.018,5.018,0,0,1,3.569-1.44,5.167,5.167,0,0,1,3.569,1.44L30.753,16A4.84,4.84,0,0,1,32.2,19.639l-.17,5.589,3.229,3.133a.083.083,0,0,1,.085-.085l2.209.931a2.005,2.005,0,0,0,.68.169,1.556,1.556,0,0,0,1.529-1.016A2.042,2.042,0,0,0,38.655,26.159Z""/><path id=""Path_77"" data-name=""Path 77"" class=""cls-1"" d=""M30.669,28.872l.17-7.028a1.535,1.535,0,0,0-.51-1.185l-5.268-5.25a1.679,1.679,0,1,0-2.379,2.371l4.758,4.742-.17,5.5-5.523.169-4.758-4.742a1.679,1.679,0,0,0-2.379,2.371l5.268,5.25a1.68,1.68,0,0,0,1.19.508h.085l7.137-.169L38.911,41.743a1.647,1.647,0,0,0,2.379,0,1.709,1.709,0,0,0,0-2.371Z"" transform=""translate(-2.125 -2.289)""/></g></svg>";
			var harvest = context.EventTypes.FirstOrDefault(e => e.Id == 11);
			harvest.svgPath = @"<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 40 34""><g id=""Group"" transform=""translate(-0.998)""><path id=""Fill_1498"" data-name=""Fill 1498"" class=""cls-1"" d=""M3.333,0H0V3.4H3.333Z"" transform=""translate(19.332)""/><path id=""Fill_1499"" data-name=""Fill 1499"" class=""cls-1"" d=""M4.713,2.4,2.356,0,0,2.4l2.356,2.4Z"" transform=""translate(25.711 2.284)""/><path id=""Fill_1500"" data-name=""Fill 1500"" class=""cls-1"" d=""M0,3.4H3.333V0H0Z"" transform=""translate(29.331 10.2)""/><path id=""Fill_1501"" data-name=""Fill 1501"" class=""cls-1"" d=""M4.713,2.4,2.356,0,0,2.4l2.356,2.4Z"" transform=""translate(11.572 2.284)""/><path id=""Fill_1502"" data-name=""Fill 1502"" class=""cls-1"" d=""M3.333,0H0V3.4H3.333Z"" transform=""translate(9.332 10.2)""/><path id=""Fill_1503"" data-name=""Fill 1503"" class=""cls-1"" d=""M38.333,17H1.669A1.672,1.672,0,0,1,.25,16.194,1.721,1.721,0,0,1,.177,14.54L6.844.939A1.673,1.673,0,0,1,8.335,0H31.667a1.653,1.653,0,0,1,1.489.939l6.666,13.6a1.713,1.713,0,0,1-.073,1.654A1.669,1.669,0,0,1,38.333,17ZM27.4,3.4l3.75,10.2h4.477l-5-10.2Zm-5.737,0V13.6h5.925L23.845,3.4Zm-5.512,0h0l-3.75,10.2h5.928V3.4H16.155Zm-6.79,0-5,10.2h4.48L12.6,3.4H9.365Z"" transform=""translate(0.998 17)""/><path id=""Fill_1504"" data-name=""Fill 1504"" class=""cls-1"" d=""M11.359,10.2H1.974A1.67,1.67,0,0,1,.4,9.068,6.84,6.84,0,0,1,0,6.8,6.741,6.741,0,0,1,6.666,0a6.742,6.742,0,0,1,6.667,6.8,6.84,6.84,0,0,1-.4,2.269A1.673,1.673,0,0,1,11.359,10.2ZM6.666,3.4A3.371,3.371,0,0,0,3.333,6.8H10a3.417,3.417,0,0,0-.978-2.4A3.278,3.278,0,0,0,6.666,3.4Z"" transform=""translate(14.332 5.1)""/></g></svg>";
			context.SaveChanges();
		}

		public static void DoWork(ApplicationDbContext context)
        {
            //var permacultureBedsGardeningType = context.GardeningTypes.Where(g => g.Id == 0).FirstOrDefault();
            //var verticalTowersGardeningType = context.GardeningTypes.Where(g => g.Id == 1).FirstOrDefault();
            //var towerGardenGardeningType = context.GardeningTypes.Where(g => g.Id == 2).FirstOrDefault();
            //var allGardeningType = context.GardeningTypes.Where(g => g.Id == 3).FirstOrDefault();
            //var fishTanksGardeningType = context.GardeningTypes.Where(g => g.Id == 4).FirstOrDefault();

            //var lightWateringLevel = context.WateringLevels.Where(g => g.Id == 0).FirstOrDefault();
            //var moderateWateringLevel = context.WateringLevels.Where(g => g.Id == 1).FirstOrDefault();
            //var normalWateringLevel = context.WateringLevels.Where(g => g.Id == 2).FirstOrDefault();
            //var maximumWateringLevel = context.WateringLevels.Where(g => g.Id == 3).FirstOrDefault();

            //var januaryMonth = context.Months.Where(g => g.Id == 0).FirstOrDefault();
            //var februaryMonth = context.Months.Where(g => g.Id == 1).FirstOrDefault();
            //var marchMonth = context.Months.Where(g => g.Id == 2).FirstOrDefault();
            //var aprilMonth = context.Months.Where(g => g.Id == 3).FirstOrDefault();
            //var mayMonth = context.Months.Where(g => g.Id == 4).FirstOrDefault();
            //var juneMonth = context.Months.Where(g => g.Id == 5).FirstOrDefault();
            //var julyMonth = context.Months.Where(g => g.Id == 6).FirstOrDefault();
            //var augustMonth = context.Months.Where(g => g.Id == 7).FirstOrDefault();
            //var septemberMonth = context.Months.Where(g => g.Id == 8).FirstOrDefault();
            //var octoberMonth = context.Months.Where(g => g.Id == 9).FirstOrDefault();
            //var novemberMonth = context.Months.Where(g => g.Id == 10).FirstOrDefault();
            //var decemberMonth = context.Months.Where(g => g.Id == 11).FirstOrDefault();

            //var prodUnitTypeBalcony = context.ProductionUnitTypes.Where(m => m.Id == 1).FirstOrDefault();
            //var prodUnitTypeCity = context.ProductionUnitTypes.Where(m => m.Id == 2).FirstOrDefault();
            //var prodUnitTypeFam14 = context.ProductionUnitTypes.Where(m => m.Id == 3).FirstOrDefault();
            //var prodUnitTypeFam22 = context.ProductionUnitTypes.Where(m => m.Id == 4).FirstOrDefault();
            //var prodUnitTypeFarm = context.ProductionUnitTypes.Where(m => m.Id == 5).FirstOrDefault();
            //var prodUnitTypeDevKit = context.ProductionUnitTypes.Where(m => m.Id == 6).FirstOrDefault();
            //var prodUnitTypeExperimental = context.ProductionUnitTypes.Where(m => m.Id == 7).FirstOrDefault();

            //var prodUnitStatusWait = context.ProductionUnitStatus.Where(m => m.Id == 1).FirstOrDefault();
            //var prodUnitStatusReadyForInstall = context.ProductionUnitStatus.Where(m => m.Id == 2).FirstOrDefault();
            //var prodUnitStatusRunning = context.ProductionUnitStatus.Where(m => m.Id == 3).FirstOrDefault();
            //var prodUnitStatusMaintenance = context.ProductionUnitStatus.Where(m => m.Id == 4).FirstOrDefault();
            //var prodUnitStatusStopped = context.ProductionUnitStatus.Where(m => m.Id == 5).FirstOrDefault();

            //var hydroTypeNotApplicable = context.HydroponicTypes.Where(m => m.Id == 1).FirstOrDefault();
            //var hydroTypeBioponics = context.HydroponicTypes.Where(m => m.Id == 2).FirstOrDefault();
            //var hydroTypeAquaponicsCarp = context.HydroponicTypes.Where(m => m.Id == 3).FirstOrDefault();
            //var hydroTypeAquaponicsTilapia = context.HydroponicTypes.Where(m => m.Id == 4).FirstOrDefault();
            //var hydroTypeAquaponicsTruit = context.HydroponicTypes.Where(m => m.Id == 5).FirstOrDefault();
            //var hydroTypeAquaponicsCrayfish = context.HydroponicTypes.Where(m => m.Id == 6).FirstOrDefault();
            //var hydroTypeAquaponicsColdFish = context.HydroponicTypes.Where(m => m.Id == 7).FirstOrDefault();
            //var hydroTypeAquaponicsWarmFish = context.HydroponicTypes.Where(m => m.Id == 8).FirstOrDefault();

            //var towers11Option = context.Options.Where(m => m.Id == 0).FirstOrDefault();
            //var towers18Option = context.Options.Where(m => m.Id == 1).FirstOrDefault();
            //var towers24Option = context.Options.Where(m => m.Id == 2).FirstOrDefault();
            //var towers36Option = context.Options.Where(m => m.Id == 3).FirstOrDefault();
            //var solarPanelOption = context.Options.Where(m => m.Id == 4).FirstOrDefault();
            //var pelletStoveOption = context.Options.Where(m => m.Id == 5).FirstOrDefault();
            //var monitoringKitv1Option = context.Options.Where(m => m.Id == 6).FirstOrDefault();
            //var monitoringKitv2Option = context.Options.Where(m => m.Id == 7).FirstOrDefault();
            //var advancedMonitoringOption = context.Options.Where(m => m.Id == 8).FirstOrDefault();
            //var touchlessScreenOption = context.Options.Where(m => m.Id == 9).FirstOrDefault();
            //var sigfoxConnectionOption = context.Options.Where(m => m.Id == 10).FirstOrDefault();
            //var permacultureBedOption = context.Options.Where(m => m.Id == 11).FirstOrDefault();
            //var permacultureBiocharOption = context.Options.Where(m => m.Id == 12).FirstOrDefault();

            //var userCTA = new ApplicationUser() { Email = "colette@myfood.eu", UserName = "colette@myfood.eu" };
            ////var userGME = new ApplicationUser() { Email = "gerard@myfood.eu", UserName = "gerard@myfood.eu" };
            ////var userMGV = new ApplicationUser() { Email = "michelg@myfood.eu", UserName = "michelg@myfood.eu" };
            ////var userFBA = new ApplicationUser() { Email = "felix@myfood.eu", UserName = "felix@myfood.eu" };
            ////var userCGT = new ApplicationUser() { Email = "casinoforges@myfood.eu", UserName = "casinoforges@myfood.eu" };
            ////var userMBA = new ApplicationUser() { Email = "myriam@myfood.eu", UserName = "myriam@myfood.eu" };

            //var store = new UserStore<ApplicationUser>(context);
            //var manager = new ApplicationUserManager(store);

            //var defaultPassword = ConfigurationManager.AppSettings["defaultPassword"];

            //var t = Task.Run(async () =>
            //{
            //    await manager.CreateAsync(userCTA, defaultPassword);
            //    //await manager.CreateAsync(userGME, defaultPassword);
            //    //await manager.CreateAsync(userMGV, defaultPassword);
            //    //await manager.CreateAsync(userFBA, defaultPassword);
            //    //await manager.CreateAsync(userCGT, defaultPassword);
            //    //await manager.CreateAsync(userMBA, defaultPassword);
            //});

            //t.Wait();

            //var ColetteTOwner = new ProductionUnitOwner() { Id = 49, user = userCTA, pioneerCitizenName = "Colette T." };
            ////var GerardMOwner = new ProductionUnitOwner() { Id = 50, user = userGME, pioneerCitizenName = "Gérard M." };
            ////var MichelGOwner = new ProductionUnitOwner() { Id = 51, user = userMGV, pioneerCitizenName = "Michel G." };
            ////var FelixBOwner = new ProductionUnitOwner() { Id = 52, user = userFBA, pioneerCitizenName = "Felix B." };
            ////var CasinoForgesFOwner = new ProductionUnitOwner() { Id = 53, user = userCGT, pioneerCitizenName = "Casino Forges" };
            ////var MyriamBOwner = new ProductionUnitOwner() { Id = 54, user = userMBA, pioneerCitizenName = "Myriam B." };

            //context.ProductionUnitOwners.Add(ColetteTOwner);
            ////context.ProductionUnitOwners.Add(GerardMOwner);
            ////context.ProductionUnitOwners.Add(MichelGOwner);
            ////context.ProductionUnitOwners.Add(FelixBOwner);
            ////context.ProductionUnitOwners.Add(CasinoForgesFOwner);
            ////context.ProductionUnitOwners.Add(MyriamBOwner);

            //var CTAProdUnit = new ProductionUnit()
            //{
            //    locationLatitude = 48.9311498,
            //    locationLongitude = 2.188086,
            //    reference = "FTATXX",
            //    info = "Restaurant Luzzu",
            //    startDate = new DateTime(2017, 07, 8),
            //    version = "2",
            //    owner = ColetteTOwner,
            //    productionUnitType = prodUnitTypeFam22,
            //    hydroponicType = hydroTypeAquaponicsWarmFish,
            //    productionUnitStatus = prodUnitStatusRunning,
            //};

            ////var GMEProdUnit = new ProductionUnit()
            ////{
            ////    locationLatitude = 44.2419021,
            ////    locationLongitude = -1.0765354,
            ////    reference = "FTAT03",
            ////    info = "Family Experimentation",
            ////    startDate = new DateTime(2017, 07, 13),
            ////    version = "2",
            ////    owner = GerardMOwner,
            ////    productionUnitType = prodUnitTypeFam22,
            ////    hydroponicType = hydroTypeAquaponicsWarmFish,
            ////    productionUnitStatus = prodUnitStatusReadyForInstall,
            ////};

            ////var MGVProdUnit = new ProductionUnit()
            ////{
            ////    locationLatitude = 48.8715998,
            ////    locationLongitude = 2.1457637,
            ////    reference = "FTAT57",
            ////    info = "Family Experimentation",
            ////    startDate = new DateTime(2017, 07, 03),
            ////    version = "2",
            ////    owner = MichelGOwner,
            ////    productionUnitType = prodUnitTypeFam22,
            ////    hydroponicType = hydroTypeAquaponicsWarmFish,
            ////    productionUnitStatus = prodUnitStatusReadyForInstall,
            ////};

            ////var FBAProdUnit = new ProductionUnit()
            ////{
            ////    locationLatitude = 51.4408238,
            ////    locationLongitude = 6.8759363,
            ////    reference = "FTAT01",
            ////    info = "Family Experimentation",
            ////    startDate = new DateTime(2017, 07, 06),
            ////    version = "2",
            ////    owner = FelixBOwner,
            ////    productionUnitType = prodUnitTypeFam14,
            ////    hydroponicType = hydroTypeAquaponicsWarmFish,
            ////    productionUnitStatus = prodUnitStatusReadyForInstall,
            ////};

            ////var CGTProdUnit = new ProductionUnit()
            ////{
            ////    locationLatitude = 49.6129522,
            ////    locationLongitude = 1.5162938,
            ////    reference = "FTAT03",
            ////    info = "Family Experimentation",
            ////    startDate = new DateTime(2017, 07, 18),
            ////    version = "2",
            ////    owner = CasinoForgesFOwner,
            ////    productionUnitType = prodUnitTypeFam22,
            ////    hydroponicType = hydroTypeAquaponicsWarmFish,
            ////    productionUnitStatus = prodUnitStatusReadyForInstall,
            ////};

            ////var MBAProdUnit = new ProductionUnit()
            ////{
            ////    locationLatitude = 48.7439002,
            ////    locationLongitude = 7.2836429,
            ////    reference = "FTAT57",
            ////    info = "Family Experimentation",
            ////    startDate = new DateTime(2017, 07, 20),
            ////    version = "2",
            ////    owner = MyriamBOwner,
            ////    productionUnitType = prodUnitTypeFam22,
            ////    hydroponicType = hydroTypeAquaponicsWarmFish,
            ////    productionUnitStatus = prodUnitStatusReadyForInstall,
            ////};

            //context.ProductionUnits.Add(CTAProdUnit);
            ////context.ProductionUnits.Add(GMEProdUnit);
            ////context.ProductionUnits.Add(MGVProdUnit);
            ////context.ProductionUnits.Add(FBAProdUnit);
            ////context.ProductionUnits.Add(CGTProdUnit);
            ////context.ProductionUnits.Add(MBAProdUnit);

            //context.SaveChanges();

            //var optionsCTA = new List<OptionList>();

            //optionsCTA.Add(new OptionList() { productionUnit = CTAProdUnit, option = monitoringKitv2Option });
            //optionsCTA.Add(new OptionList() { productionUnit = CTAProdUnit, option = towers18Option });
            //optionsCTA.Add(new OptionList() { productionUnit = CTAProdUnit, option = sigfoxConnectionOption });
            //optionsCTA.Add(new OptionList() { productionUnit = CTAProdUnit, option = permacultureBedOption });

            ////var optionsGME = new List<OptionList>();

            ////optionsGME.Add(new OptionList() { productionUnit = GMEProdUnit, option = monitoringKitv2Option });
            ////optionsGME.Add(new OptionList() { productionUnit = GMEProdUnit, option = towers18Option });
            ////optionsGME.Add(new OptionList() { productionUnit = GMEProdUnit, option = permacultureBedOption });
            ////optionsGME.Add(new OptionList() { productionUnit = GMEProdUnit, option = sigfoxConnectionOption });

            ////var optionsMGV = new List<OptionList>();

            ////optionsMGV.Add(new OptionList() { productionUnit = MGVProdUnit, option = monitoringKitv2Option });
            ////optionsMGV.Add(new OptionList() { productionUnit = MGVProdUnit, option = towers24Option });
            ////optionsMGV.Add(new OptionList() { productionUnit = MGVProdUnit, option = sigfoxConnectionOption });
            ////optionsMGV.Add(new OptionList() { productionUnit = MGVProdUnit, option = permacultureBedOption });

            ////var optionsFBA = new List<OptionList>();

            ////optionsFBA.Add(new OptionList() { productionUnit = FBAProdUnit, option = monitoringKitv2Option });
            ////optionsFBA.Add(new OptionList() { productionUnit = FBAProdUnit, option = towers18Option });
            ////optionsFBA.Add(new OptionList() { productionUnit = FBAProdUnit, option = permacultureBiocharOption });
            ////optionsFBA.Add(new OptionList() { productionUnit = FBAProdUnit, option = sigfoxConnectionOption });

            ////var optionsCGT = new List<OptionList>();

            ////optionsCGT.Add(new OptionList() { productionUnit = CGTProdUnit, option = monitoringKitv2Option });
            ////optionsCGT.Add(new OptionList() { productionUnit = CGTProdUnit, option = towers18Option });
            ////optionsCGT.Add(new OptionList() { productionUnit = CGTProdUnit, option = sigfoxConnectionOption });
            ////optionsCGT.Add(new OptionList() { productionUnit = CGTProdUnit, option = pelletStoveOption });

            ////var optionsMBA = new List<OptionList>();

            ////optionsMBA.Add(new OptionList() { productionUnit = MBAProdUnit, option = monitoringKitv2Option });
            ////optionsMBA.Add(new OptionList() { productionUnit = MBAProdUnit, option = towers18Option });
            ////optionsMBA.Add(new OptionList() { productionUnit = MBAProdUnit, option = solarPanelOption });
            ////optionsMBA.Add(new OptionList() { productionUnit = MBAProdUnit, option = permacultureBedOption });

            //context.OptionLists.AddRange(optionsCTA);
            ////context.OptionLists.AddRange(optionsGME);
            ////context.OptionLists.AddRange(optionsMGV);
            ////context.OptionLists.AddRange(optionsFBA);
            ////context.OptionLists.AddRange(optionsCGT);
            ////context.OptionLists.AddRange(optionsMBA);

            //context.SaveChanges();

        }
    }
}