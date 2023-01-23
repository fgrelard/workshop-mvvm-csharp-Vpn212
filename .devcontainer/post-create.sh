## Enable local HTTPS for .NET
dotnet dev-certs https --trust

## Install Coverlet
dotnet tool install --global coverlet.console --configfile NuGet.Config
dotnet tool install --global dotnet-reportgenerator-globaltool --configfile NuGet.Config

## Install Metrix++
pip install metrixpp

## Install PMD
# brew install pmd

## OH-MY-ZSH PLUGINS & THEMES (POWERLEVEL10K) ##
# Uncomment the below to install oh-my-zsh plugins and themes (powerlevel10k) without dotfiles integration
 git clone https://github.com/zsh-users/zsh-completions.git $HOME/.oh-my-zsh/custom/plugins/zsh-completions
 git clone https://github.com/zsh-users/zsh-syntax-highlighting.git $HOME/.oh-my-zsh/custom/plugins/zsh-syntax-highlighting
 git clone https://github.com/zsh-users/zsh-autosuggestions.git $HOME/.oh-my-zsh/custom/plugins/zsh-autosuggestions
 git clone https://github.com/romkatv/powerlevel10k.git $HOME/.oh-my-zsh/custom/themes/powerlevel10k --depth=1
 ln -s $HOME/.oh-my-zsh/custom/themes/powerlevel10k/powerlevel10k.zsh-theme $HOME/.oh-my-zsh/custom/themes/powerlevel10k.zsh-theme

## OH-MY-ZSH - POWERLEVEL10K SETTINGS ##
# Uncomment the below to update the oh-my-zsh settings without dotfiles integration
 curl https://raw.githubusercontent.com/justinyoo/devcontainers-dotnet/main/oh-my-zsh/.p10k-with-clock.zsh > $HOME/.p10k-with-clock.zsh
 curl https://raw.githubusercontent.com/justinyoo/devcontainers-dotnet/main/oh-my-zsh/.p10k-without-clock.zsh > $HOME/.p10k-without-clock.zsh
 curl https://raw.githubusercontent.com/justinyoo/devcontainers-dotnet/main/oh-my-zsh/switch-p10k-clock.sh > $HOME/switch-p10k-clock.sh
 chmod +x ~/switch-p10k-clock.sh
 cp $HOME/.p10k-with-clock.zsh $HOME/.p10k.zsh
 cp $HOME/.zshrc $HOME/.zshrc.bak
 echo "$(cat $HOME/.zshrc)" | awk '{gsub(/ZSH_THEME=\"codespaces\"/, "ZSH_THEME=\"powerlevel10k\"")}1' > $HOME/.zshrc.replaced && mv $HOME/.zshrc.replaced $HOME/.zshrc
 echo "$(cat $HOME/.zshrc)" | awk '{gsub(/plugins=\(git\)/, "plugins=(git zsh-completions zsh-syntax-highlighting zsh-autosuggestions dotnet)")}1' > $HOME/.zshrc.replaced && mv $HOME/.zshrc.replaced $HOME/.zshrc
 echo "
 # To customize prompt, run 'p10k configure' or edit ~/.p10k.zsh.
 [[ ! -f ~/.p10k.zsh ]] || source ~/.p10k.zsh
 " >> $HOME/.zshrc