package br.senai.sp.informatica.exemplologin.config;

import br.senai.sp.informatica.exemplologin.service.LoginService;
import retrofit2.Retrofit;
import retrofit2.converter.jackson.JacksonConverterFactory;

public class RetrofitConfig {
    private static RetrofitConfig instance;
    private final Retrofit retrofit;

    public static RetrofitConfig getInstance() {
        if(instance == null)
          instance = new RetrofitConfig();
        return instance;
    }

    private RetrofitConfig() {
        this.retrofit = new Retrofit.Builder()
                .baseUrl(AppUtils.API_BASE_URL)
                .addConverterFactory(JacksonConverterFactory.create())
                .build();
    }

    public LoginService getLoginService() {
        return this.retrofit.create(LoginService.class);
    }
}