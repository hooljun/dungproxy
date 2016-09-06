﻿//============================================================
//http://codelover.link author:李国宝
//============================================================

using proxyipcenter_dotnet.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace proxyipcenter_dotnet.Model
{	
	[Serializable()]
    
    /// <summary>
    /// 
    /// </summary>
	public class Proxy
    {

        private static readonly ProxyDAL dal = new ProxyDAL();

        #region 属性

        /// <summary>
        /// 主键
        /// </summary>
		public long id{get;set;}
            
        /// <summary>
        /// IP地址
        /// </summary>
		public string ip{get;set;}
            
        /// <summary>
        /// 代理IP，也就是目标网站最终看到的IP（多级代理的情况ip和proxy_ip不会相同）
        /// </summary>
		public string proxy_ip{get;set;}
            
        /// <summary>
        /// 端口号
        /// </summary>
		public int? port{get;set;}
            
        /// <summary>
        /// ip的数字表示，用于过滤连续IP问题
        /// </summary>
		public long? ip_value{get;set;}
            
        /// <summary>
        /// 国家
        /// </summary>
		public string country{get;set;}
            
        /// <summary>
        /// 地区
        /// </summary>
		public string area{get;set;}
            
        /// <summary>
        /// 省
        /// </summary>
		public string region{get;set;}
            
        /// <summary>
        /// 市
        /// </summary>
		public string city{get;set;}
            
        /// <summary>
        /// 运营商
        /// </summary>
		public string isp{get;set;}
            
        /// <summary>
        /// 国家代码
        /// </summary>
		public string country_id{get;set;}
            
        /// <summary>
        /// 地区代码
        /// </summary>
		public string area_id{get;set;}
            
        /// <summary>
        /// 省级代码
        /// </summary>
		public string region_id{get;set;}
            
        /// <summary>
        /// 城市代码
        /// </summary>
		public string city_id{get;set;}
            
        /// <summary>
        /// isp代码
        /// </summary>
		public string isp_id{get;set;}
            
        /// <summary>
        /// 地理位置ID，融合各个地理位置获取的一个数字，数值约接近表示实际地理位置约接近
        /// </summary>
		public long? address_id{get;set;}
            
        /// <summary>
        /// 透明度(高匿，普通，透明)
        /// </summary>
		public sbyte? transperent{get;set;}
            
        /// <summary>
        /// 连接时间（越小速度越快）
        /// </summary>
		public long? speed{get;set;}
            
        /// <summary>
        /// 类型（http，https,httpAndHttps,socket,qq）
        /// </summary>
		public sbyte? type{get;set;}
            
        /// <summary>
        /// 连接性打分
        /// </summary>
		public long connection_score{get;set;}
            
        /// <summary>
        /// 可用性打分
        /// </summary>
		public long availbel_score{get;set;}
            
        /// <summary>
        /// 连接性打分时间
        /// </summary>
		public DateTime? connection_score_date{get;set;}
            
        /// <summary>
        /// 可用性打分时间
        /// </summary>
		public DateTime? availbel_score_date{get;set;}
            
        /// <summary>
        /// 收录时间
        /// </summary>
		public DateTime createtime{get;set;}
            
        /// <summary>
        /// 是否支持翻墙
        /// </summary>
		public sbyte? support_gfw{get;set;}
            
        /// <summary>
        /// 翻墙访问速度
        /// </summary>
		public long? gfw_speed{get;set;}
            
        /// <summary>
        /// 资源来源url
        /// </summary>
		public string source{get;set;}
            
        /// <summary>
        /// 爬虫key，用户统计爬虫收集分布
        /// </summary>
		public string crawler_key{get;set; }


        #endregion


        #region

        /// <summary>
        /// 加载可用的代理数据
        /// </summary>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        public static IEnumerable<Proxy> LoadAvailableProxyList(int pageCount=0)
        {
            return dal.GetAvailableProxyList(pageCount);
        }

        #endregion
    }
}
