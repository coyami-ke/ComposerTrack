// Console ComposerTrack.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <vector>
#include <sstream>
#include <Windows.h>
#include <tchar.h>

int main()
{
    std::cout << "Welcome to Console ComposerTrack by dropsy. Enter <help> to getting help.\n";
    std::cout << "Command: ";
    std::string command;

    std::cin >> command;

    std::vector<std::string> args;

    std::istringstream iss(command);

    for (std::string arg; iss >> arg; ) {
        args.push_back(arg);
    }

    if (args[0] == "start" && args[1] == "") {
        STARTUPINFO startup_info;
        PROCESS_INFORMATION process_info;
    }
    if (args[0] == "start" && args[1] == "debug") {

    }
    if (args.)

}
