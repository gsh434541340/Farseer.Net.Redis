using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Redis.Internal;

namespace FS.Redis
{
    public class RedisPubSub
    {
        /// <summary>
        /// Redis客户端
        /// </summary>
        private readonly RedisClient _redisClient;
        private RedisPubSub() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="redisClient">Redis客户端</param>
        internal RedisPubSub(RedisClient redisClient)
        {
            _redisClient = redisClient;
        }
    }
}
