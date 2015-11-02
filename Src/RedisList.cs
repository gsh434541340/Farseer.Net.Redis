using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Redis.Internal;

namespace FS.Redis
{
    public class RedisList
    {
        /// <summary>
        /// Redis客户端
        /// </summary>
        private readonly RedisClient _redisClient;
        private RedisList() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="redisClient">Redis客户端</param>
        internal RedisList(RedisClient redisClient)
        {
            _redisClient = redisClient;
        }
    }
}
