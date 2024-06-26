﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using WCFOrders.Model.Entities;

namespace WCFOrders
{
    [ServiceContract]
    public interface IOrderService
    {
        /// <summary>
        /// Method to get list of Items
        /// </summary>
        /// <returns>List of items</returns>
        [OperationContract]
        List<ItemForView> GetItems();

        /// <summary>
        /// Method to get sorted by name list of Items
        /// </summary>
        /// <returns>Sorted list of items</returns>
        [OperationContract]
        List<ItemForView> GetItemSortByName();
    }

    [DataContract]
    public class ItemForView
    {
        [DataMember]
        public int IdItem { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Decription { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public decimal? Price { get; set; }
        [DataMember]
        public decimal? Quantity { get; set; }
        [DataMember]
        public string FotoUrl { get; set; }
        [DataMember]
        public string UnitOfMeasurementName { get; set; }
        [DataMember]
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public ItemForView() { }
        public ItemForView(Item item)
        {
            IdItem = item.IdItem;
            Name = item.Name;
            Decription = item.Description;
            CategoryName = item.Category.Name;
            Price = item.Price;
            Quantity = item.Quantity;
            FotoUrl = item.FotoUrl;
            UnitOfMeasurementName = item.UnitOfMeasurement.Name;
            Code = item.Code;
            IsActive = item.IsActive;
        }
    }

}
