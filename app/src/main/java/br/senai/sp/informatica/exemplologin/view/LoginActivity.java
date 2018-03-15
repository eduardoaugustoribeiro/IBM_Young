package br.senai.sp.informatica.exemplologin.view;

import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import br.senai.sp.informatica.exemplologin.R;
import br.senai.sp.informatica.exemplologin.repository.LoginRepo;
import br.senai.sp.informatica.exemplologin.model.Usuario;
import okhttp3.ResponseBody;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class LoginActivity extends AppCompatActivity {
    private EditText edLogin;
    private EditText edSenha;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.login_activity);

        edLogin = findViewById(R.id.edLogin);
        edSenha = findViewById(R.id.edSenha);

//        if(LoginRepo.dao.obterToken() != null)
//            abreTelaPrincipal();
    }

    public void abreTelaPrincipal() {
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }

    public void enviaClick(View view) {
        String login = edLogin.getText().toString();
        String senha = edSenha.getText().toString();

        Usuario usuario = new Usuario();
        usuario.setLogin(login);
        usuario.setSenha(senha);

        LoginRepo.dao.efetuaLogin(usuario, new Callback<ResponseBody>() {
            @Override
            public void onResponse(Call<ResponseBody> requisicao, Response<ResponseBody> resposta) {
                if(resposta.isSuccessful()) {
//                    LoginRepo.dao.salvarToken(resposta.headers().get("authorization"));
                    Log.e("LoginActivity",  "Trx: " + resposta.headers().get("x-apiary-transaction-id"));
                    abreTelaPrincipal();
                }
            }

            @Override
            public void onFailure(Call<ResponseBody> requisicao, Throwable erro) {
                Toast.makeText(LoginActivity.this, "Falha na Autenticação", Toast.LENGTH_LONG).show();
            }
        });
    }
}
