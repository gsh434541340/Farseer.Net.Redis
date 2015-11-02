using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Redis.Internal;

namespace FS.Redis
{
    public class RedisSet
    {
        /// <summary>
        /// Redis客户端
        /// </summary>
        private readonly RedisClient _redisClient;
        private RedisSet() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="redisClient">Redis客户端</param>
        internal RedisSet(RedisClient redisClient)
        {
            _redisClient = redisClient;
        }
    }
}
