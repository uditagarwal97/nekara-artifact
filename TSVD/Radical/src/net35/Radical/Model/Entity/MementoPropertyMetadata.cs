﻿using System;
using System.Linq.Expressions;
using Topics.Radical.Linq;
using Topics.Radical.Reflection;
using Topics.Radical.ComponentModel.ChangeTracking;

namespace Topics.Radical.Model
{
    //public static class MementoPropertyMetadataBuilder
    //{
    //    public class TypedMementoPropertyMetadataBuilder<T>
    //    {
    //        public MementoPropertyMetadata<TValue> And<TValue>( Expression<Func<T, TValue>> property )
    //        {
    //            var name = property.GetMemberName();
    //            return new MementoPropertyMetadata<TValue>( name );
    //        }
    //    }

    //    public static TypedMementoPropertyMetadataBuilder<T> For<T>()
    //    {
    //        return new TypedMementoPropertyMetadataBuilder<T>();
    //    }
    //}

    public static class MementoPropertyMetadata
    {
        public static MementoPropertyMetadata<T> Create<T>( Object propertyOwner, Expression<Func<T>> property )
        {
            return new MementoPropertyMetadata<T>( propertyOwner, property );
        }

        public static MementoPropertyMetadata<T> Create<T>( Object propertyOwner, String propertyName )
        {
            return new MementoPropertyMetadata<T>( propertyOwner, propertyName );
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">The type of the property.</typeparam>
    public class MementoPropertyMetadata<T> : PropertyMetadata<T>,
        IMementoPropertyMetadata
    {
        public MementoPropertyMetadata( Object propertyOwner, String propertyName )
            : base( propertyOwner, propertyName )
        {
            if ( this.Property.IsAttributeDefined<MementoPropertyMetadataAttribute>() )
            {
                var attribute = this.Property.GetAttribute<MementoPropertyMetadataAttribute>();
                this.TrackChanges = attribute.TrackChanges;
            }
            else
            {
                this.TrackChanges = true;
            }
        }

        public MementoPropertyMetadata( Object propertyOwner, Expression<Func<T>> property )
            : this( propertyOwner, property.GetMemberName() )
        {

        }

        public Boolean TrackChanges { get; set; }

        public MementoPropertyMetadata<T> DisableChangesTracking()
        {
            this.TrackChanges = false;
            return this;
        }

        public MementoPropertyMetadata<T> EnableChangesTracking()
        {
            this.TrackChanges = true;
            return this;
        }
    }

    [AttributeUsage( AttributeTargets.Property )]
    public class MementoPropertyMetadataAttribute : PropertyMetadataAttribute
    {
        public MementoPropertyMetadataAttribute()
        {
            this.TrackChanges = true;
        }

        public Boolean TrackChanges { get; set; }
    }
}
