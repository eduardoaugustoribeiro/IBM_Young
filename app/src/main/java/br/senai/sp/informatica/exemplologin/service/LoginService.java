package br.senai.sp.informatica.exemplologin.service;

import br.senai.sp.informatica.exemplologin.model.Usuario;
import okhttp3.ResponseBody;
import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.POST;

public interface LoginService {
    @POST("login")
    Call<ResponseBody> efetuarLogin(@Body Usuario usuario);
}
