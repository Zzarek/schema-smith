﻿using SchemaSmith.Linting.YamlNodes;

namespace SchemaSmith.Linting.Neo4j.YamlNodeValidationDefinitions;

internal class Index : MappingNodeValidationDefinition
{
    public Index()
    {
        RequiredProperties = new Dictionary<string, NodeValidationDefinition>
        {
            { "name", new IndexName() },
            { "type", new IndexType() },
            { "entity", new IndexEntity() }
        };
    }
}