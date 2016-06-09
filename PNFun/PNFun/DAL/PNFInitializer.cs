using PNFun.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PNFun.DAL
{
    public class PNFInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PNFContext>
    {
        protected override void Seed(PNFContext context)
        {
            //context = new PNFContext();
            // Seeding the Category database
            
            //Category cat = new Category();
            //int SnowID;
            //int FishingID;
            //int WaterID;
            //int TrailsID;
            //int SceneryID;
            //int CampingID;
            //int CavesID;
            //int PicnickingID;
            //int BeachesID;
            //int ExtremeID;
            //int GhostTownsID;
            //int tempID;
            //int SeaCavesID;


            //cat.Name = "Snow Recreation";
            //cat.PhotoLocation = "/Content/Images/Snow3.jpg";
            //cat.BackgroundPhotoLocation = "/Content/Images/Snow2.jpg";
            //cat.AltDescription = "Snow Recreation";
            //cat.Ranking = 1;
            //cat.Hits = 0;
            //context.CategoryDb.Add(cat);
            //context.SaveChanges();
            //SnowID = cat.ID;

            //cat = new Category();
            //cat.Name = "Fishing";
            //cat.PhotoLocation = "/Content/Images/Fishing.jpg";
            //cat.BackgroundPhotoLocation = "/Content/Images/Fishing1.jpg";
            //cat.AltDescription = "Fishing";
            //cat.Ranking = 2;
            //cat.Hits = 0;
            //context.CategoryDb.Add(cat);
            //context.SaveChanges();
            //FishingID = cat.ID;

            //cat = new Category();
            //cat.Name = "Water Fun";
            //cat.PhotoLocation = "/Content/Images/WaterFun5.jpg";
            //cat.BackgroundPhotoLocation = "/Content/Images/WaterFun4.jpg";
            //cat.AltDescription = "Water Fun";
            //cat.Ranking = 10;
            //cat.Hits = 0;
            //context.CategoryDb.Add(cat);
            //context.SaveChanges();
            //WaterID = cat.ID;

            //cat = new Category();
            //cat.Name = "Trails";
            //cat.PhotoLocation = "/Content/Images/hiking2.jpg";
            //cat.BackgroundPhotoLocation = "/Content/Images/hiking3.jpg";
            //cat.AltDescription = "Trails";
            //cat.Ranking = 4;
            //cat.Hits = 0;
            //context.CategoryDb.Add(cat);
            //context.SaveChanges();
            //TrailsID = cat.ID;

            //cat = new Category();
            //cat.Name = "Scenery";
            //cat.PhotoLocation = "/Content/Images/ScenicView.jpg";
            //cat.BackgroundPhotoLocation = "/Content/Images/View1.jpg";
            //cat.AltDescription = "Senic Views";
            //cat.Ranking = 3;
            //cat.Hits = 0;
            //context.CategoryDb.Add(cat);
            //context.SaveChanges();
            //SceneryID = cat.ID;

            //cat = new Category();
            //cat.Name = "Camping";
            //cat.PhotoLocation = "/Content/Images/Camping.jpg";
            //cat.BackgroundPhotoLocation = "/Content/Images/Camping2.jpg";
            //cat.AltDescription = "Camping";
            //cat.Ranking = 9;
            //cat.Hits = 0;
            //context.CategoryDb.Add(cat);
            //context.SaveChanges();
            //CampingID = cat.ID;

            //cat = new Category();
            //cat.Name = "Caves";
            //cat.PhotoLocation = "/Content/Images/Cave3.gif";
            //cat.BackgroundPhotoLocation = "/Content/Images/Cave4.jpg";
            //cat.AltDescription = "Caves";
            //cat.Ranking = 8;
            //cat.Hits = 0;
            //context.CategoryDb.Add(cat);
            //context.SaveChanges();
            //CavesID = cat.ID;

            //cat = new Category();
            //cat.Name = "Picnicking";
            //cat.PhotoLocation = "/Content/Images/Picnicing.jpg";
            //cat.BackgroundPhotoLocation = "/Content/Images/picnic.jpg";
            //cat.AltDescription = "Picnicking";
            //cat.Ranking = 5;
            //cat.Hits = 0;
            //context.CategoryDb.Add(cat);
            //context.SaveChanges();
            //PicnickingID = cat.ID;

            //cat = new Category();
            //cat.Name = "Beaches";
            //cat.PhotoLocation = "/Content/Images/beach1.jpg";
            //cat.BackgroundPhotoLocation = "/Content/Images/Beach.jpg";
            //cat.AltDescription = "Beaches";
            //cat.Ranking = 6;
            //cat.Hits = 0;
            //context.CategoryDb.Add(cat);
            //context.SaveChanges();
            //BeachesID = cat.ID;

            //cat = new Category();
            //cat.Name = "Extreme Fun";
            //cat.PhotoLocation = "/Content/Images/Extreme.png";
            //cat.BackgroundPhotoLocation = "/Content/Images/Extreme2.jpg";
            //cat.AltDescription = "Extreme Fun";
            //cat.Ranking = 0;
            //cat.Hits = 7;
            //context.CategoryDb.Add(cat);
            //context.SaveChanges();
            //ExtremeID = cat.ID;

            //cat = new Category();
            //cat.Name = "Ghost Towns";
            //cat.PhotoLocation = "/Content/Images/GhostTown1.jpg";
            //cat.BackgroundPhotoLocation = "/Content/Images/GhostTown2.jpg";
            //cat.AltDescription = "Ghost Towns";
            //cat.Ranking = 11;
            //cat.Hits = 7;
            //context.CategoryDb.Add(cat);
            //context.SaveChanges();
            //GhostTownsID = cat.ID;

            //// Seeding the SubCategory Database

            //SubCategory subcat = new SubCategory();
            //LinkCategoryToSubCategory linkcategorytosubcategory = new LinkCategoryToSubCategory();


            //subcat.Name = "Fly Fishing";
            //subcat.PhotoLocation = "/Content/Images/FishingFly.jpg";
            //subcat.BackgroundPhotoLocation = "/Content/Images/Fishing1.jpg";
            //subcat.AltDescription = "Fly Fishing";
            //subcat.Ranking = 1;
            //subcat.Hits = 0;
            //context.SubCategoryDb.Add(subcat);
            //context.SaveChanges();
            //tempID = subcat.ID;
            //linkcategorytosubcategory.CategoryId = FishingID;
            //linkcategorytosubcategory.LinkedToId = tempID;
            //context.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
            //context.SaveChanges();


            //subcat.Name = "Lake Fishing";
            //subcat.PhotoLocation = "/Content/Images/FishingLake.jpg";
            //subcat.BackgroundPhotoLocation = "/Content/Images/Fishing1.jpg";
            //subcat.AltDescription = "Lake Fishing";
            //subcat.Ranking = 1;
            //subcat.Hits = 0;
            //context.SubCategoryDb.Add(subcat);
            //context.SaveChanges();
            //tempID = subcat.ID;
            //linkcategorytosubcategory.CategoryId = FishingID;
            //linkcategorytosubcategory.LinkedToId = tempID;
            //context.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
            //context.SaveChanges();

            //subcat.Name = "River Fishing";
            //subcat.PhotoLocation = "/Content/Images/FishingRiver.jpg";
            //subcat.BackgroundPhotoLocation = "/Content/Images/Fishing1.jpg";
            //subcat.AltDescription = "River Fishing";
            //subcat.Ranking = 1;
            //subcat.Hits = 0;
            //context.SubCategoryDb.Add(subcat);
            //context.SaveChanges();
            //tempID = subcat.ID;
            //linkcategorytosubcategory.CategoryId = FishingID;
            //linkcategorytosubcategory.LinkedToId = tempID;
            //context.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
            //context.SaveChanges();

            //subcat.Name = "Ocean Fishing";
            //subcat.PhotoLocation = "/Content/Images/FishingOcean.jpg";
            //subcat.BackgroundPhotoLocation = "/Content/Images/Fishing1.jpg";
            //subcat.AltDescription = "Ocean Fishing";
            //subcat.Ranking = 1;
            //subcat.Hits = 0;
            //context.SubCategoryDb.Add(subcat);
            //context.SaveChanges();
            //tempID = subcat.ID;
            //linkcategorytosubcategory.CategoryId = FishingID;
            //linkcategorytosubcategory.LinkedToId = tempID;
            //context.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
            //context.SaveChanges();

            //subcat.Name = "Trout Fishing";
            //subcat.PhotoLocation = "/Content/Images/Trout.jpg";
            //subcat.BackgroundPhotoLocation = "/Content/Images/Fishing1.jpg";
            //subcat.AltDescription = "Trout Fishing";
            //subcat.Ranking = 1;
            //subcat.Hits = 0;
            //context.SubCategoryDb.Add(subcat);
            //context.SaveChanges();
            //tempID = subcat.ID;
            //linkcategorytosubcategory.CategoryId = FishingID;
            //linkcategorytosubcategory.LinkedToId = tempID;
            //context.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
            //context.SaveChanges();

            //subcat.Name = "Bass Fishing";
            //subcat.PhotoLocation = "/Content/Images/Bass.jpg";
            //subcat.BackgroundPhotoLocation = "/Content/Images/Fishing1.jpg";
            //subcat.AltDescription = "Bass Fishing";
            //subcat.Ranking = 1;
            //subcat.Hits = 0;
            //context.SubCategoryDb.Add(subcat);
            //context.SaveChanges();
            //tempID = subcat.ID;
            //linkcategorytosubcategory.CategoryId = FishingID;
            //linkcategorytosubcategory.LinkedToId = tempID;
            //context.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
            //context.SaveChanges();

            //subcat.Name = "Salmon Fishing";
            //subcat.PhotoLocation = "/Content/Images/Salmon.jpg";
            //subcat.BackgroundPhotoLocation = "/Content/Images/Fishing1.jpg";
            //subcat.AltDescription = "Salmons Fishing";
            //subcat.Ranking = 1;
            //subcat.Hits = 0;
            //context.SubCategoryDb.Add(subcat);
            //context.SaveChanges();
            //tempID = subcat.ID;
            //linkcategorytosubcategory.CategoryId = FishingID;
            //linkcategorytosubcategory.LinkedToId = tempID;
            //context.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
            //context.SaveChanges();

            //subcat.Name = "White Sand";
            //subcat.PhotoLocation = "/Content/Images/Beach2.jpg";
            //subcat.BackgroundPhotoLocation = "/Content/Images/Beach.jpg";
            //subcat.AltDescription = "White Sand";
            //subcat.Ranking = 1;
            //subcat.Hits = 0;
            //context.SubCategoryDb.Add(subcat);
            //context.SaveChanges();
            //tempID = subcat.ID;
            //linkcategorytosubcategory.CategoryId = BeachesID;
            //linkcategorytosubcategory.LinkedToId = tempID;
            //context.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
            //context.SaveChanges();

            //subcat.Name = "Lighthouses";
            //subcat.PhotoLocation = "/Content/Images/lighthouse.jpg";
            //subcat.BackgroundPhotoLocation = "/Content/Images/Beach.jpg";
            //subcat.AltDescription = "Lighthouses";
            //subcat.Ranking = 1;
            //subcat.Hits = 0;
            //context.SubCategoryDb.Add(subcat);
            //context.SaveChanges();
            //tempID = subcat.ID;
            //linkcategorytosubcategory.CategoryId = BeachesID;
            //linkcategorytosubcategory.LinkedToId = tempID;
            //context.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
            //context.SaveChanges();

            //subcat.Name = "Sea Caves";
            //subcat.PhotoLocation = "/Content/Images/SeaCave.jpg";
            //subcat.BackgroundPhotoLocation = "/Content/Images/Beach.jpg";
            //subcat.AltDescription = "Sea Caves";
            //subcat.Ranking = 1;
            //subcat.Hits = 0;
            //context.SubCategoryDb.Add(subcat);
            //context.SaveChanges();
            //tempID = subcat.ID;
            //linkcategorytosubcategory.CategoryId = BeachesID;
            //linkcategorytosubcategory.LinkedToId = tempID;
            //context.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
            //context.SaveChanges();
            //SeaCavesID = tempID;

            //subcat.Name = "Sea Lions";
            //subcat.PhotoLocation = "/Content/Images/SeaLions.jpg";
            //subcat.BackgroundPhotoLocation = "/Content/Images/Beach.jpg";
            //subcat.AltDescription = "Sea Lions";
            //subcat.Ranking = 1;
            //subcat.Hits = 0;
            //context.SubCategoryDb.Add(subcat);
            //context.SaveChanges();
            //tempID = subcat.ID;
            //linkcategorytosubcategory.CategoryId = BeachesID;
            //linkcategorytosubcategory.LinkedToId = tempID;
            //context.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
            //context.SaveChanges();

            //subcat.Name = "Semi Precious Stones";
            //subcat.PhotoLocation = "/Content/Images/Stones.jpg";
            //subcat.BackgroundPhotoLocation = "/Content/Images/Beach.jpg";
            //subcat.AltDescription = "Semi Precious Stones";
            //subcat.Ranking = 1;
            //subcat.Hits = 0;
            //context.SubCategoryDb.Add(subcat);
            //context.SaveChanges();
            //tempID = subcat.ID;
            //linkcategorytosubcategory.CategoryId = BeachesID;
            //linkcategorytosubcategory.LinkedToId = tempID;
            //context.LinkCategoryToSiteDb.Add(linkcategorytosubcategory);
            //context.SaveChanges();

            //context.SaveChanges();

            ////Seeding for Recreation Sites

            //RecreationSite recsite = new RecreationSite();

            //recsite.access = PNFun.Models.Access.moderate;
            //recsite.AltDescription = "Crescent Beach Caves";
            //recsite.Cost = 5;
            //recsite.Directions = "Along coast highway 101, just south of Cannon Beach";
            //recsite.ImageString = "/Content/Images/BeachCave.jpg";
            //recsite.Name = "Crescent Beach";
            //recsite.MapLink = "https://www.google.com/maps/place/Crescent+Beach/@45.9145509,-123.970139,15z/data=!3m1!4b1!4m2!3m1!1s0x5494a4595480bff3:0x6ba5a0460aff6965";
            //recsite.Page = "Crescent beach is a 2.4 mile hike down from Ecola State Park in Oregon. This coastal beach features sandy beaches and some impressive sea caves that are accessible at low tide.";
            //recsite.Rating = 4;
            //recsite.restrooms = PNFun.Models.Restrooms.flush;
            //recsite.Zipcode = "97110";
            //context.RecreationSiteDb.Add(recsite);
            //context.SaveChanges();
            //tempID = recsite.ID;
            //LinkSubCategoryToSite link = new LinkSubCategoryToSite();
            //link.SubCategoryId = SeaCavesID;
            //link.LinkedToId = tempID;
            //context.LinkSubCategoryToSiteDb.Add(link);
            //context.SaveChanges();

            //recsite.access = PNFun.Models.Access.easy;
            //recsite.AltDescription = "Sea Lion Caves";
            //recsite.Cost = 25;
            //recsite.Directions = "NA";
            //recsite.ImageString = "/Content/Images/BeachCave.jpg";
            //recsite.Name = "Sea Lion Caves";
            //recsite.MapLink = "https://www.google.com/maps/place/Crescent+Beach/@45.9145509,-123.970139,15z/data=!3m1!4b1!4m2!3m1!1s0x5494a4595480bff3:0x6ba5a0460aff6965";
            //recsite.Page = "Crescent beach is a 2.4 mile hike down from Ecola State Park in Oregon. This coastal beach features sandy beaches and some impressive sea caves that are accessible at low tide.";
            //recsite.Rating = 4;
            //recsite.restrooms = PNFun.Models.Restrooms.flush;
            //recsite.Zipcode = "97110";
            //context.RecreationSiteDb.Add(recsite);
            //context.SaveChanges();
            //tempID = recsite.ID;
            //link = new LinkSubCategoryToSite();
            //link.SubCategoryId = SeaCavesID;
            //link.LinkedToId = tempID;
            //context.LinkSubCategoryToSiteDb.Add(link);
            //context.SaveChanges();

            //recsite.access = PNFun.Models.Access.easy;
            //recsite.AltDescription = "Cannon Caves";
            //recsite.Cost = 10;
            //recsite.Directions = "NA";
            //recsite.ImageString = "/Content/Images/BeachCave.jpg";
            //recsite.Name = "Cannon Caves";
            //recsite.MapLink = "https://www.google.com/maps/place/Crescent+Beach/@45.9145509,-123.970139,15z/data=!3m1!4b1!4m2!3m1!1s0x5494a4595480bff3:0x6ba5a0460aff6965";
            //recsite.Page = "Crescent beach is a 2.4 mile hike down from Ecola State Park in Oregon. This coastal beach features sandy beaches and some impressive sea caves that are accessible at low tide.";
            //recsite.Rating = 1;
            //recsite.restrooms = PNFun.Models.Restrooms.none;
            //recsite.Zipcode = "97110";
            //context.RecreationSiteDb.Add(recsite);
            //context.SaveChanges();
            //tempID = recsite.ID;
            //link = new LinkSubCategoryToSite();
            //link.SubCategoryId = SeaCavesID;
            //link.LinkedToId = tempID;
            //context.LinkSubCategoryToSiteDb.Add(link);
            //context.SaveChanges();

            //recsite.access = PNFun.Models.Access.easy;
            //recsite.AltDescription = "Really Wet Caves";
            //recsite.Cost = 15;
            //recsite.Directions = "NA";
            //recsite.ImageString = "/Content/Images/BeachCave.jpg";
            //recsite.Name = "Really Wet Caves";
            //recsite.MapLink = "https://www.google.com/maps/place/Crescent+Beach/@45.9145509,-123.970139,15z/data=!3m1!4b1!4m2!3m1!1s0x5494a4595480bff3:0x6ba5a0460aff6965";
            //recsite.Page = "Crescent beach is a 2.4 mile hike down from Ecola State Park in Oregon. This coastal beach features sandy beaches and some impressive sea caves that are accessible at low tide.";
            //recsite.Rating = 4;
            //recsite.restrooms = PNFun.Models.Restrooms.flush;
            //recsite.Zipcode = "97110";
            //context.RecreationSiteDb.Add(recsite);
            //context.SaveChanges();
            //tempID = recsite.ID;
            //link = new LinkSubCategoryToSite();
            //link.SubCategoryId = SeaCavesID;
            //link.LinkedToId = tempID;
            //context.LinkSubCategoryToSiteDb.Add(link);
            //context.SaveChanges();

            //recsite.access = PNFun.Models.Access.easy;
            //recsite.AltDescription = "Lost Caves";
            //recsite.Cost = 25;
            //recsite.Directions = "NA";
            //recsite.ImageString = "/Photos/Content/Images.jpg";
            //recsite.Name = "Lost Caves";
            //recsite.MapLink = "https://www.google.com/maps/place/Crescent+Beach/@45.9145509,-123.970139,15z/data=!3m1!4b1!4m2!3m1!1s0x5494a4595480bff3:0x6ba5a0460aff6965";
            //recsite.Page = "Crescent beach is a 2.4 mile hike down from Ecola State Park in Oregon. This coastal beach features sandy beaches and some impressive sea caves that are accessible at low tide.";
            //recsite.Rating = 5;
            //recsite.restrooms = PNFun.Models.Restrooms.flush;
            //recsite.Zipcode = "97110";
            //context.RecreationSiteDb.Add(recsite);
            //context.SaveChanges();
            //tempID = recsite.ID;
            //link = new LinkSubCategoryToSite();
            //link.SubCategoryId = SeaCavesID;
            //link.LinkedToId = tempID;
            //context.LinkSubCategoryToSiteDb.Add(link);
            //context.SaveChanges();
        }

    }
}
