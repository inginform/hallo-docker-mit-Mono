FROM mono:3.10.0

MAINTAINER Jan Suchotzki <jan@suchotzki.de>

# Git
# RUN echo "deb http://http.debian.net/debian wheezy-backports main" > /etc/apt/sources.list.d/wheezy-backports.list
RUN apt-get update -y \ 
		&& apt-get install -y git \
		&& rm -rf /var/lib/apt/lists/* /tmp/* /var/tmp/*

# HalloDocker Quellcode holen -> wiederholen, wenn neue Version des Quellcodes?
RUN mkdir -p /usr/src/app
WORKDIR /usr/src/app
RUN git clone https://github.com/suchja/inginform.git .

# Quellcode kompilieren
# Ausführen