﻿using Grand.Domain.Topics;
using Grand.Admin.Models.Topics;

namespace Grand.Admin.Extensions
{
    public static class TopicMappingExtensions
    {
        public static TopicModel ToModel(this Topic entity)
        {
            return entity.MapTo<Topic, TopicModel>();
        }

        public static Topic ToEntity(this TopicModel model)
        {
            return model.MapTo<TopicModel, Topic>();
        }

        public static Topic ToEntity(this TopicModel model, Topic destination)
        {
            return model.MapTo(destination);
        }
    }
}