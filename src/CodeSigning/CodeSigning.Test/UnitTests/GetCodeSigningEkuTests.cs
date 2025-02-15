﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.CodeSigning;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Moq;
using System;
using Xunit;


namespace Microsoft.Azure.Commands.CodeSigning.Test.UnitTests
{
    public class GetCodeSigningEkuTests : CodeSigningUnitTestBase
    {
        private GetAzureCodeSigningCustomerEku cmdlet;


        public GetCodeSigningEkuTests()
        {
            base.SetupTest();

            cmdlet = new GetAzureCodeSigningCustomerEku()
            {
                CommandRuntime = commandRuntimeMock.Object,
                CodeSigningServiceClient = codeSigningServiceClientMock.Object,
            };

        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void CanGetCodeSigningEkuTest()
        {
            string expected = "testEku";
            // Mock the should process to return true
            commandRuntimeMock.Setup(cr => cr.ShouldProcess(AccountName,It.IsAny<string>())).Returns(true);
            cmdlet.AccountName = AccountName;
            cmdlet.ProfileName = ProfileName;
            cmdlet.EndpointUrl = EndPointUrl;

            cmdlet.ExecuteCmdlet();

            // Without PassThru never call WriteObject
            commandRuntimeMock.Verify(f => f.WriteObject(expected), Times.Never());
        }
    }
}
