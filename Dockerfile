FROM mcr.microsoft.com/dotnet/sdk:5.0
RUN apt update 
RUN apt install git
RUN git clone https://github.com/DejanPopovic1/Iteration1.git
RUN git clone https://github.com/DejanPopovic1/Iteration2.git