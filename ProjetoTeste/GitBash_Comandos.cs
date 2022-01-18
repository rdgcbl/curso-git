/*
  *Passo a Passo
    -instalar o gitbash
    -criar um gitignore na pasta inicial do repositorio 'ren gitignore.txt .gitignore' // para renomear o arquivo txt para .gitignore
    -no gitbash digite 
    
    1° git init
  1.2° git config -- global user.name "Rodrigo Kipper" // grava meu nome           //Se nao estiver cadastrado, precisa cadastrar
  1.3° git config -- global user.email "rodrigo@hot.." // grava meu email          //Se nao estiver cadastrado, precisa cadastrar
    2º git add .
    3º git comit -m "Concluido"
    4° git remote add origin https://github.com/rdgcbl/curso-udemy-c-.git
    5° git push -u origin master
    6º senha git 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
    7º FINISH    
        
------------------------------------------------------------------------------------------------------------- 
  git push -u origin master          // mandar as informacoes para o github pela primeira ves
  git push                           // mandar as informacoes para o gihub depois de ja ter mandado
  git add .                          // esse comando grava e fica pronto para commitar
  git status                         // verifica se esta untracked(vermelho) e staged(verde) depois eh soh "add."
  git commit -m "O que foi feito     // ele faz o commit, faz o registro
  git log                            // tras os resultados os log do que foi feito
  git log --oneline                  // tras o resumo em uma linha
-------------------------------------------------------------------------------------------------------------    
   caso esquecer de digitar a mensagem no "commit -m" vai abrir o editor 'VIM', para sair aperta "ESC" e depois digite
 :q!
   pronto, tecle enter e refaz o commit novamente
-------------------------------------------------------------------------------------------------------------
   remover o ultimo commit mantendo as alteracoes no visualstudio
 git reset --soft HEAD~1
-------------------------------------------------------------------------------------------------------------
   remover o ultimo commit e removendo as alteracoes no visualstudio
 git reset --hard HEAD~1  
-------------------------------------------------------------------------------------------------------------
   como voltar temporariamente entre os commits:
 git checkout 219a9ca   //digitar o <codigo do comit> que eu desejo voltar
   e para retomar ao commit atual eu digito:
 git checkout master    //nome do branch
-------------------------------------------------------------------------------------------------------------
   *Associar nosso repositorio local ao repositorio remoto no site GitHub, dando apelido 'Origin'
 git remote add origin <URI do repositorio remoto>
 git remote add origin https://github.com/rdgcbl/curso-git.git
   *Associar nosso repositorio local a um outro repositorio remoto no site GitHub, mantendo o apelido 'Origin'
 git remote set-url origin <URI do repositorio remoto>
 git remote set-url origin https://github.com/rdgcbl/curso-git.git
-------------------------------------------------------------------------------------------------------------
   *Como transferir o repositorio que esta na minha maquina(PC) para o repositorio do site GitHub(Remoto)
   posso fazer uma vez apenas e ele ja vai memorizar(digitar no GitBash)
 git push -u origin master
   *Em caso de alteracoes nos codigos, como transferir da maquina para o site github novamente. É só digitar
   (digitar no GitBash)
 git push
-------------------------------------------------------------------------------------------------------------
  *Como transferir um projeto que esta no github(nuvem) para a minha maquina(PC)
 git clone https://github.com/rdgcbl/curso-git.git
-------------------------------------------------------------------------------------------------------------
  *Como atualizar um projeto que outra pessoa esta ajudando a fazer
 git pull origin master
  *dessa maneira seu colega fez alteracoes no github e vc usou o comando 'pull'
  para atualizar o projeto do seu 'PC'
-------------------------------------------------------------------------------------------------------------
FINALIZADO GIT HUB
iniciando repositorio curso udemy c#
-------------------------------------------------------------------------------------------------------------

*/
