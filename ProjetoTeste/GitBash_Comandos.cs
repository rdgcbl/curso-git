/*
  git config -- global user.name "Rodrigo Kipper" // grava meu nome
  git config -- global user.email "rodrigo@hot.." // grava meu email
------------------------------------------------------------------------------------------------------------- 
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
  *



-------------------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------------------

*/