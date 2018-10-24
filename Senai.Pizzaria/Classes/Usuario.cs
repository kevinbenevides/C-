using System;
namespace Senai.Pizzaria.Classes {
    public class Usuario {
        static Usuario[] arrayUsuario = new Usuario[10000];
        static int contador = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }

        #region Métodos
        /// <summary>
        /// Método para execução de cadastro:
        /// </summary>
        /// <param name="usuario"></param>

        public static void Inserir () {
            string nome;
            string email;
            string senha;

            System.Console.WriteLine ("\nDigite o Nome que deseja cadastrar:");
            nome = Console.ReadLine ();

            do {
                Console.WriteLine ("\nDigite o E-mail que deseja cadastrar:");
                email = Console.ReadLine ();

                if (!email.Contains ("@") || !email.Contains (".")) {
                    Console.WriteLine ("\nE-mail inválido. ");
                } else {
                    Console.WriteLine ("\nE-mail Válido");
                }

            } while (!email.Contains ("@") || !email.Contains ("."));

            do {
                Console.WriteLine ("\nDigite a Senha que deseja cadastrar:");
                senha = Console.ReadLine ();

                if (senha.Length < 6) {
                    Console.WriteLine ("\nSenha inválida.");
                } else {
                    Console.WriteLine ("\nSenha Válida");
                }

            } while (senha.Length < 6);

            arrayUsuario[contador] = new Usuario ();
            arrayUsuario[contador].Id = contador + 1;
            arrayUsuario[contador].Nome = nome;
            arrayUsuario[contador].Email = email;
            arrayUsuario[contador].Senha = senha;
            arrayUsuario[contador].DataCriacao = DateTime.Now;
            contador++;

        }

        /// <summary>
        /// Método para Efetuar o Login
        /// </summary>
        public static void EfetuarLogin () {
            string EmailLogin, SenhaLogin;
            bool usuarioValido = false;

            do {
                Console.WriteLine ("Digite o seu Email:");
                EmailLogin = Console.ReadLine ();

                Console.WriteLine ("Digite sua Senha:");
                SenhaLogin = Console.ReadLine ();

                foreach (Usuario usuario in arrayUsuario) {
                    if (usuario != null) {
                        if (EmailLogin == usuario.Email && SenhaLogin == usuario.Senha) {
                            return;
                        } else {
                            Console.WriteLine ("E-mail ou Senha incorretos.");
                        }
                    }
                }
            } while (!usuarioValido);
        }

        /// <summary>
        /// Método para Listar Usuários
        /// </summary>
        public static void Listar () {
            //Exibindo os usuários
            foreach (Usuario u in arrayUsuario) {
                //Verificando se o u for diferete de nulo
                if (u == null) break;

                Console.WriteLine ($"[{u.Id}] - Nome:{u.Nome}; Email:{u.Email}; Senha: {u.Senha}; Data de Criação:{u.DataCriacao.ToShortDateString()}");
                contador++;
            }
        }
        #endregion

    }
}