ARG VARIANT=6.0-bullseye
FROM mcr.microsoft.com/devcontainers/dotnet:0-${VARIANT}

# [Choice] Node.js version: none, lts/*, 18, 16, 14
ARG NODE_VERSION="none"
RUN if [ "${NODE_VERSION}" != "none" ]; then su vscode -c "umask 0002 && . /usr/local/share/nvm/nvm.sh && nvm install ${NODE_VERSION} 2>&1"; fi


RUN echo 'export PATH=$PATH:/home/vscode/.dotnet/tools' >> /home/vscode/.profile && \
    echo 'export PATH=$PATH:/home/vscode/.dotnet/tools' >> /home/vscode/.zshrc
# [Optional] Uncomment this section to install additional OS packages.
 RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
     && apt-get -y install --no-install-recommends graphviz
# [Optional] Uncomment this line to install global node packages.
# RUN su vscode -c "source /usr/local/share/nvm/nvm.sh && npm install -g <your-package-here>" 2>&1