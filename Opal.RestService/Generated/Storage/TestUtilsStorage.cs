//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Opal.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ITestUtilsStorage interface definition.
    /// </summary>
    public interface ITestUtilsStorage : IStorage
    {
        
        /// <summary>
        /// >> Enabled
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetEnabled();
        
        /// <summary>
        /// >> TestValue
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetTestValue();
    }
    
    /// <summary>
    /// TestUtilsStorage class definition.
    /// </summary>
    public sealed class TestUtilsStorage : ITestUtilsStorage
    {
        
        /// <summary>
        /// _enabledTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _enabledTypedStorage;
        
        /// <summary>
        /// _testValueTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _testValueTypedStorage;
        
        /// <summary>
        /// TestUtilsStorage constructor.
        /// </summary>
        public TestUtilsStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.EnabledTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("TestUtils.Enabled", storageDataProvider, storageChangeDelegates);
            this.TestValueTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("TestUtils.TestValue", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _enabledTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> EnabledTypedStorage
        {
            get
            {
                return _enabledTypedStorage;
            }
            set
            {
                _enabledTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _testValueTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> TestValueTypedStorage
        {
            get
            {
                return _testValueTypedStorage;
            }
            set
            {
                _testValueTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await EnabledTypedStorage.InitializeAsync("TestUtils", "Enabled");
            await TestValueTypedStorage.InitializeAsync("TestUtils", "TestValue");
        }
        
        /// <summary>
        /// Implements any storage change for TestUtils.Enabled
        /// </summary>
        [StorageChange("TestUtils", "Enabled")]
        public void OnUpdateEnabled(string data)
        {
            EnabledTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Enabled
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetEnabled()
        {
            return EnabledTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for TestUtils.TestValue
        /// </summary>
        [StorageChange("TestUtils", "TestValue")]
        public void OnUpdateTestValue(string data)
        {
            TestValueTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> TestValue
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetTestValue()
        {
            return TestValueTypedStorage.Get();
        }
    }
}
