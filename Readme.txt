This is an example of EF DAO integration test. It shows how to integrate test DAO it with both MSTest and NUnit.

Solution structure
* MainApp project: a simple console app, call dao to add record and get record count
	> App.config: db connection string config
	> Program.cs: console main class
	> Product.cs: POJO
	> MyContext.cs: EF Db context
	> ProductRepository.cs: DAO

* DbIntegrationTestWithMSTest project: DAO integration test with MSTest. Should add nuget package "EF"
	> App.config: db connection string config
		Note: the db connection name must be same as the connection name in MainApp app.config.
		Note: should add "AttachDbFileName" attribute to set db file path under "DataDirectory".		 
	> TestDbInitializer.cs: db initializer with MyContext class
	> TestGlobal.cs: all mstest case global setting. it executes following actions before every test case runs
		* Define "DataDirectory" attribute value as current directory ("bin").
		* !!Set "TestDbInitializer" instance as EF db initializer to drop and recreate db before every test case run!!
	> ProductRepositoryTest.cs: ProductRepository DAO test case

* DbIntegrationTestWithNUnit project: DAO integration test with NUnit. Should add nuget packages "EF" and "NUnit"
	> App.config: db connection string config
		Note: the db connection name must be same as the connection name in MainApp app.config.
		Note: should add "AttachDbFileName" attribute to set db file path under "DataDirectory".s		 
	> TestDbInitializer.cs: db initializer with MyContext class
	> TestGlobal.cs: all mstest case global setting. it executes following actions before every test case runs
		* Define "DataDirectory" attribute value as current directory ("bin").
		* !!Set "TestDbInitializer" instance as EF db initializer to drop and recreate db before every test case run!!
	> ProductRepositoryTest.cs: ProductRepository DAO test case

