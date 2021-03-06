﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSZ.DTO;

namespace ZSZ.IService
{
    public interface IHouseService:IServiceSupport
    {
        HouseFindDTO GetById(long id);

        //获取typeId这种房源类别下cityId这个城市中房源的总数量
        long GetTotalCount(long cityId, long typeId);

        //分页获取typeId这种房源类别下cityId这个城市中房源
        HouseFindDTO[] GetPagedData(long cityId, long typeId, int pageSize, int currentIndex);

        //新增房源，返回房源id
        long AddNew(HouseNewDTO house);

        //更新房源，房源的附件先删除再新增
        void Update(HouseFindDTO house);

        //软删除
        void MarkDeleted(long id);

        //得到房源的图片
        HousePicDTO[] GetPics(long houseId);

        //添加房源图片
        long AddNewHousePic(HousePicDTO housePic);

        //软删除房源图片
        void DeleteHousePic(long housePicId);

        //搜索，返回值包含：总条数和HouseDTO[] 两个属性
        HouseSearchResult Search(HouseSearchOptions options);

        long GetCount(long cityId, DateTime startDateTime, DateTime endDateTime);
    }

}
