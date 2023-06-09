﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpDemo1.Pages;

public class Index_Tests : AbpDemo1WebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
