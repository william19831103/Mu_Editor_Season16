﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_MU.Models
{
    internal class Sql_Querys
    {
        public string authenticate =
            "" +
            "SELECT   " +
            "accounts.account," +
            "accounts.password," +
            "accounts.blocked," +
            "accounts.security_code," +
            "accounts.golden_channel," +
            "accounts.facebook_status," +
            "accounts.secured," +
            "accounts.email," +
            "accounts.register," +
            "accounts.type_account, " +
            "accounts.guid " +
            "FROM " +
            "accounts " +
            "WHERE " +
            "accounts.account = '" + Account.account + "' " +
            "AND " +
            "accounts.password = '" + Account.password + "'";

        public string changeSecureSelect =
            "SELECT " +
            "accounts.secured," +
            "accounts.security_code " +
            "FROM accounts " +
            "WHERE " +
            "accounts.account = '" + Account.account + "'";

        public string changeSecureUpdate =
            "UPDATE " +
            "accounts " +
            "SET " +
            "secured = " + infoAccounts.secured + "," +
            "security_code = '" + infoAccounts.secured_code + "' " +
            "WHERE " +
            "account = 'maikiller'";

        public string admin_info_account =
            "" +
            "SELECT " +
            "accounts.account," +
            "accounts.password," +
            "accounts.blocked," +
            "accounts.security_code," +
            "accounts.golden_channel," +
            "accounts.facebook_status," +
            "accounts.secured," +
            "accounts.email," +
            "accounts.register," +
            "accounts.type_account," +
            "account_data.vip_status," +
            "account_data.vip_duration," +
            "account_data.credits," +
            "account_data.current_ip " +
            "FROM " +
            "mu_online_login.accounts," +
            "mu_online_characters.account_data " +
            "WHERE " +
            "accounts.guid = " + infoAccounts.guid + " " +
            "AND " +
            "account_data.account_id = " + infoAccounts.account_id + "";

        public string admin_all_player =
            "" +
            "SELECT " +
            "accounts.guid," +
            "accounts.account " +
            "FROM " +
            "accounts";

        public string admin_info_account_save =
            "UPDATE " +
            "mu_online_login.accounts SET " +
            "email = '" + infoAccounts.email + "'," +
            "blocked = " + infoAccounts.blocked + ", " +
            "type_account = " + infoAccounts.type_account + " " +
            "WHERE " +
            "guid = " + infoAccounts.guid + ";  " +
            "UPDATE " +
            "mu_online_characters.account_data " +
            "SET " +
            "vip_status =" + infoAccounts.vip_status + ", " +
            "vip_duration = " + infoAccounts.vip_duration + ", " +
            "credits = " + infoAccounts.credits + " " +
            "WHERE " +
            "account_id = " + infoAccounts.account_id + ";";

        public string save_user =
            "INSERT INTO accounts (account, password, email, golden_channel, secured, register)" +
            "VALUES('" + Account.account + "', '" + Account.password + "', '" + Account.email + "', 0, 0, TIMESTAMP(NOW()))";

        public string all_characters =
            "SELECT " +
            "character_info.guid," +
            "character_info.name " +
            "FROM " +
            "mu_online_characters.character_info";

        public string all_character_detail =
            "SELECT " +
            "character_info.name," +
            "character_info.create_date," +
            "character_info.online," +
            "character_info.level," +
            "character_info.level_master," +
            "character_info.level_majestic," +
            "character_info.experience," +
            "character_info.experience_master," +
            "character_info.experience_majestic," +
            "character_info.points," +
            "character_info.points_master," +
            "character_info.points_majestic," +
            "character_info.strength," +
            "character_info.agility," +
            "character_info.vitality," +
            "character_info.energy," +
            "character_info.leadership," +
            "character_info.money," +
            "character_info.goblin_points," +
            "character_info.add_fruit_points," +
            "character_info.dec_fruit_points," +
            "character_info.admin_flags, " +
            "character_info.authority," +
            "character_info.race " +
            "FROM character_info " +
            "WHERE " +
            "character_info.guid = '" + Characters.guid + "'";

        public string all_character_detail_save =
             "UPDATE character_info " +
               "SET " +
               "name = '" + Characters.name + "'," +
               "create_date = " + Characters.create_date + "," +
               "level = " + Characters.level + "," +
               "level_master = " + Characters.level_master + "," +
               "level_majestic = " + Characters.level_majestic + "," +
               "experience = " + Characters.experience + "," +
               "experience_master = " + Characters.experience_master + "," +
               "experience_majestic = " + Characters.experience_majestic + "," +
               "points = " + Characters.points + "," +
               "points_master = " + Characters.points_master + "," +
               "points_majestic = " + Characters.points_majestic + "," +
               "strength = " + Characters.strength + "," +
               "agility = " + Characters.agility + "," +
               "vitality = " + Characters.vitality + "," +
               "energy = " + Characters.energy + "," +
               "leadership = " + Characters.leadership + "," +
               "money = " + Characters.money + "," +
               "goblin_points = " + Characters.goblin_points + "," +
               "add_fruit_points = " + Characters.add_fruit_points + "," +
               "dec_fruit_points = " + Characters.dec_fruit_points + "," +
               "admin_flags = " + Characters.admin_flags + "," +
               "authority = " + Characters.authority + "," +
               "race = " + Characters.race + " " +
            "WHERE guid = '" + Characters.guid + "'";

        //ITEMS
        public string select_npc_shop_name =
            "SELECT " +
            "shop_template.name " +
            "FROM shop_template";

        public string select_npc_shop_items =
            "SELECT " +
            "item_template.name " +
            "AS " +
            "Item_Name," +
            "shop_items.id AS Position_Bag," +
            "shop_items.durability," +
            "shop_items.guid " +
            "FROM " +
            "shop_items " +
            "INNER JOIN shop_template " +
            "ON " +
            "shop_items.shop = shop_template.guid " +
            "INNER JOIN item_template " +
            "ON " +
            "shop_items.`index` = item_template.i_index " +
            "AND " +
            "shop_items.type = item_template.i_type " +
            "WHERE " +
            "shop_template.name = '" + NpcShop.name + "' " +
            "ORDER BY Position_Bag";

        public string select_item_npc =
            "SELECT " +
            "item_template.name," +
            "shop_items.level," +
            "shop_items.durability," +
            "shop_items.skill," +
            "shop_items.luck," +
            "shop_items.`option`," +
            "shop_items.excellent," +
            "shop_items.ancient," +
            "shop_items.socket_1," +
            "shop_items.socket_2," +
            "shop_items.socket_3," +
            "shop_items.socket_4," +
            "shop_items.socket_5," +
            "shop_items.price," +
            "shop_items.shop," +
            "shop_items.type," +
            "shop_items.index," +
            "shop_items.id," +
            "shop_items.guid " +
            "FROM shop_items " +
            "INNER JOIN item_template " +
            "ON shop_items.`index` = item_template.i_index " +
            "AND shop_items.type = item_template.i_type " +
            "INNER JOIN " +
            "shop_template " +
            "ON " +
            "shop_items.shop = shop_template.guid " +
            "WHERE " +
            "item_template.name = '" + NpcShop.item + "' " +
            "AND " +
            "shop_template.name = '" + NpcShop.name + "' " +
            "AND " +
            "shop_items.durability = " + NpcShop.durability_quanty + " " +
            "AND " +
            "shop_items.guid = " + NpcShop.guid + " ";

        public string update_item_npc =
            "UPDATE " +
            "shop_items " +
            "SET " +
            "level = " + NpcShop.level + "," +
            "durability = " + NpcShop.durability + "," +
            "skill = " + NpcShop.skill + "," +
            "luck = " + NpcShop.luck + "," +
            "`option` = " + NpcShop.option + "," +
            "excellent = " + NpcShop.excellent + "," +
            "ancient = " + NpcShop.ancient + "," +
            "socket_1 = " + NpcShop.socket_1 + "," +
            "socket_2 = " + NpcShop.socket_2 + "," +
            "socket_3 = " + NpcShop.socket_3 + "," +
            "socket_4 = " + NpcShop.socket_4 + "," +
            "socket_5 = " + NpcShop.socket_5 + "," +
            "price = " + NpcShop.price + "," +
            "id = " + NpcShop.position + " " +
            "WHERE " +
            "type = " + NpcShop.typeItem + " " +
            "AND `index` = " + NpcShop.indexItem + " " +
            "AND shop = " + NpcShop.shopId + " " +
            "AND guid = " + NpcShop.guid + "";

        // Load itens from database

        public string load_itens =
            "SELECT " +
            "item_template.i_type, " +
            "item_template.i_index as ID, " +
            "item_template.name as Item " +
            "FROM item_template " +
            "WHERE " +
            "item_template.i_type = " + NpcShop.add_itemType + " " +
            "ORDER BY item_template.name";

        public string load_ID_shop =
            "SELECT shop_template.guid " +
            "FROM " +
            "shop_template " +
            "WHERE " +
            "shop_template.name = '" + NpcShop.name + "'";

        // Insert Items on NPC

        public string insert_items =
            "INSERT " +
            "INTO " +
            "shop_items (type, `index`, level, durability, skill, luck, `option`, excellent, ancient, socket_1, socket_2, socket_3, socket_4, socket_5, price, id, shop) " +
            "VALUES (" + NpcShop.add_itemType + ", " + NpcShop.add_itemIndex + ", 0, 0, 0, 0, 0, 0, 0, 65535, 65535, 65535, 65535, 65535, 0, 0, " + NpcShop.add_shop_GUID + ")";

        public string delete_items =
            "DELETE " +
            "FROM " +
            "shop_items WHERE guid = " + NpcShop.guid + "";

        //Create NPC

        public string select_npc =
            "SELECT " +
            "shop_template.guid as ID, " +
            "shop_template.name " +
            "FROM " +
            "shop_template ORDER BY shop_template.guid";

        public string selectModel =
            "SELECT " +
            "monster_template.model," +
            "monster_template.name " +
            "FROM " +
            "monster_template " +
            "ORDER " +
            "BY " +
            "monster_template.model";

        public string selectWorld =
            "SELECT " +
            "world_template.name " +
            "FROM " +
            "world_template";

        public string selectWorldEntry =
           "SELECT world_template.entry FROM world_template WHERE world_template.name = '" + NpcShop.world_name + "'";

        //table Monster
        public string insertNPC =
            "INSERT INTO monster " +
            "(server, guid, id, world, x1, y1, x2, y2, direction, spawn_delay, spawn_distance, respawn_time_min, respawn_time_max, respawn_id, move_distance, npc_function, elemental_attribute, disabled) " +
            "VALUES " +
            "(" + NpcShop.server + "," + NpcShop.id + ", " + NpcShop.model_id_selected + ", " + NpcShop.world_entry + ", " + NpcShop.x1 + ", " + NpcShop.y1 + ", " + NpcShop.x2 + ", " + NpcShop.y2 + ", " + NpcShop.direction + ", " + NpcShop.spawn_delay + ", " + NpcShop.spawn_distance + ", " + NpcShop.respawn_time_min + ", " + NpcShop.respawn_time_max + ", " + NpcShop.respawn_id + ", " + NpcShop.move_distance + ", '" + NpcShop.npc_name + "', " + NpcShop.elemental_attribute + ", " + NpcShop.disabled + ")";

        //Table Shop_Template
        public string insertShop =
            "INSERT INTO shop_template (guid, name, max_pk_level, pk_text, flag, type, max_buy_count, max_buy_type) VALUES (" + NpcShop.guidCustomNPC + ", '" + NpcShop.npc_name + "', " + NpcShop.pk_count + ", '" + NpcShop.pk_text + "', 0, 0, 0, 0)";

        //Table Monster GUID Duplicate Verifier
        public string verifierID =
            "SELECT monster.guid FROM monster WHERE monster.guid = " + NpcShop.id + "";

        //Table Shop_tamplate GUID Duplicate Verifier
        public string verifierIDShop =
            "SELECT shop_template.guid AS guid_shop FROM shop_template WHERE shop_template.guid = " + NpcShop.guidCustomNPC + "";

        public string delete_npc =
            "DELETE FROM monster WHERE npc_function = '" + NpcShop.npc_name + "'; " +
            "DELETE FROM shop_template WHERE name = '" + NpcShop.npc_name + "'";

        public string load_custom_npc =
            "SELECT " +
            "monster.server," +
            "monster.guid," +
            "monster.id," +
            "monster.world," +
            "monster.x1," +
            "monster.y1," +
            "monster.x2," +
            "monster.y2," +
            "monster.direction," +
            "monster.spawn_delay," +
            "monster.spawn_distance," +
            "monster.respawn_time_min," +
            "monster.respawn_time_max," +
            "monster.respawn_id," +
            "monster.move_distance," +
            "monster.npc_function," +
            "monster.elemental_attribute," +
            "monster.disabled," +
            "shop_template.max_pk_level," +
            "shop_template.pk_text," +
            "monster_template.name, " +
            "shop_template.guid " +
            "FROM " +
            "monster " +
            "INNER JOIN " +
            "shop_template " +
            "ON " +
            "monster.npc_function = shop_template.name " +
            "INNER JOIN " +
            "monster_template " +
            "ON monster.id = monster_template.model " +
            "WHERE " +
            "monster.npc_function = '" + NpcShop.npc_name + "'";

        public string update_npc =
            "UPDATE " +
            "monster " +
            "SET " +
            "server = " + NpcShop.server + ", " +
            "guid = " + NpcShop.id + ", " +
            "id = " + NpcShop.model_id_selected + ", " +
            "world = " + NpcShop.world_entry + ", " +
            "x1 = " + NpcShop.x1 + ", " +
            "y1 = " + NpcShop.y1 + ", " +
            "x2 = " + NpcShop.x2 + ", " +
            "y2 = " + NpcShop.y2 + ", " +
            "direction = " + NpcShop.direction + ", " +
            "spawn_delay = " + NpcShop.spawn_delay + ", " +
            "spawn_distance = " + NpcShop.spawn_distance + ", " +
            "respawn_time_min = " + NpcShop.respawn_time_min + ", " +
            "respawn_time_max = " + NpcShop.respawn_time_max + ", " +
            "respawn_id = " + NpcShop.respawn_id + ", " +
            "move_distance = " + NpcShop.move_distance + ", " +
            "npc_function = '" + NpcShop.npc_name + "', " +
            "elemental_attribute = " + NpcShop.elemental_attribute + ", " +
            "disabled = " + NpcShop.disabled + " " +
            "WHERE " +
            "npc_function = '" + NpcShop.npc_name + "'; " +
            "UPDATE " +
            "shop_template " +
            "SET " +
            "name = " + NpcShop.npc_name + ", " +
            "pk_text = '" + NpcShop.pk_text + "', " +
            "max_pk_level =  " + NpcShop.pk_count + "  " +
            "where  " +
            "name = '" + NpcShop.npc_name + "';";

        public string last_npc_guid =
        "SELECT MAX(guid) FROM shop_template";
        public string last_monster_guid =
            "SELECT MAX(guid) FROM monster";


        public string load_server_settings =
            "SELECT settings.`key`,settings.value " +
            "FROM " +
            "settings " +
            "WHERE " +
            "settings.server_id = " + ServerSettings.server_id + "";

        public string update_server_settings =
            "UPDATE " +
            "settings " +
            "SET " +
            "value = '" + ServerSettings.value + "' " +
            "WHERE " +
            "`key` = '" + ServerSettings.key + "' " +
            "AND " +
            "server_id = " + ServerSettings.server_id + "";

        public string load_all_events =
            "SELECT * FROM event_manager WHERE event_manager.server = " + ManageEvents.ServerID + "";

        public string load_event_id =
            "SELECT " +
            "event_manager.guid," +
            "event_manager.server," +
            "event_manager.event," +
            "event_manager.invasion," +
            "event_manager.duration," +
            "event_manager.notify_time," +
            "event_manager.hour," +
            "event_manager.minute," +
            "event_manager.day_of_week," +
            "event_manager.day_of_month," +
            "event_manager.season_event," +
            "event_manager.exclusive_server " +
            "FROM " +
            "event_manager " +
            "WHERE " +
            "event_manager.guid = " + ManageEvents.guid + "";

        public string update_event =
            "UPDATE event_manager SET " +
            "event = " + ManageEvents.eventID + "," +
            "invasion = " + ManageEvents.invasionID + "," +
            "duration = " + ManageEvents.duration + "," +
            "notify_time = " + ManageEvents.notify_time + "," +
            "hour = " + ManageEvents.hour + "," +
            "minute = " + ManageEvents.minute + "," +
            "day_of_week = " + ManageEvents.day_of_week + "," +
            "day_of_month = " + ManageEvents.day_of_month + "," +
            "season_event = " + ManageEvents.season_event + "," +
            "exclusive_server = " + ManageEvents.exclusive_server + " " +
            "WHERE guid = " + ManageEvents.guid + "";

        public string delete_event =
            "DELETE " +
            "FROM " +
            "event_manager " +
            "WHERE " +
            "guid = " + ManageEvents.guid + "";

        public string add_event =
            "INSERT INTO event_manager " +
            "(server, event, invasion, duration, notify_time, hour, minute, day_of_week, day_of_month, season_event, exclusive_server)" +
            "VALUES(" + ManageEvents.ServerID + ", " + ManageEvents.eventID + ", " + ManageEvents.invasionID + ", " + ManageEvents.duration + ", " + ManageEvents.notify_time + ", " + ManageEvents.hour + ", " + ManageEvents.minute + ", " + ManageEvents.day_of_week + ", " + ManageEvents.day_of_month + ", " + ManageEvents.season_event + ", " + ManageEvents.exclusive_server + ")";

        public string selectWorldEntryTeleport =
           "SELECT " +
            "world_template.entry " +
            "FROM " +
            "world_template " +
            "WHERE " +
            "world_template.name = '" + TeleportGateDestiy.worldName + "'";


        public string selectWorldEntryTeleportPortal =
           "SELECT " +
            "world_template.entry " +
            "FROM " +
            "world_template " +
            "WHERE " +
            "world_template.name = '" + PortalLocation.worldName + "'";


        public string InsertDestinyGate =
            "INSERT INTO gate_template (flag, world, x1, y1, min_level, description, x2, y2, target_id, direction) " +
            "VALUES " +
            "(" + TeleportGateDestiy.flag + ", " + TeleportGateDestiy.worldID + ", " + TeleportGateDestiy.x + ", " + TeleportGateDestiy.y + ", 0, '" + TeleportGateDestiy.description + "', " + TeleportGateDestiy.x + ", " + TeleportGateDestiy.y + ", 0, 0)";
        public string ReturnLastIDGate =
            "SELECT MAX(id) FROM gate_template;";

        public string InsertPortalLocation =
            "INSERT INTO gate_template (flag, world, x1, y1, min_level, description, x2, y2, target_id, direction) " +
            "VALUES " +
            "(" + PortalLocation.flag + ", " + PortalLocation.worldID + ", " + PortalLocation.x + ", " + PortalLocation.y + ", 0, '" + PortalLocation.description + "', " + PortalLocation.x + ", " + PortalLocation.y + ", " + PortalLocation.ID_Destiny + ", 0)";
        public string AllTeleportGates =
            "SELECT world_template.name," +
            "gate_template.id AS `ID Destiny`," +
            "gate_template.target_id AS `Portal ID`," +
            "gate_template.description FROM world_template " +
            "INNER JOIN " +
            "gate_template " +
            "ON " +
            "world_template.entry = gate_template.world";

        public string DeleteGates =
            "DELETE FROM gate_template WHERE id = " + PortalLocation.ID_Destiny + "";


        //Monster spot
        public string LoadMonster =
            "SELECT " +
            "monster_template.name " +
            "AS " +
            "monster_name," +
            "world_template.name " +
            "AS " +
            "world_name," +
            "monster.x1," +
            "monster.y1," +
            "monster.x2," +
            "monster.y2," +
            "monster.spawn_delay as delay," +
           "monster.spawn_distance as distance," +
           "monster.respawn_time_min as time_min," +
           "monster.respawn_time_max as time_max," +
            "monster.respawn_id," +
            "monster.move_distance," +
            "monster.itembag," +
            "monster.elemental_attribute," +
            "monster.id," +
            "monster.guid " +
            "FROM " +
            "monster " +
            "INNER " +
            "JOIN " +
            "world_template " +
            "ON " +
            "monster.world = world_template.entry " +
            "INNER JOIN " +
            "monster_template " +
            "ON " +
            "monster.id = monster_template.id " +
            "ORDER BY monster.id";

        public string LoadMonster_findtoWorld =
           "SELECT " +
           "monster_template.name " +
           "AS " +
           "monster_name," +
           "world_template.name " +
           "AS " +
           "world_name," +
           "monster.x1," +
           "monster.y1," +
           "monster.x2," +
           "monster.y2," +
           "monster.spawn_delay as delay," +
           "monster.spawn_distance as distance," +
           "monster.respawn_time_min as time_min," +
           "monster.respawn_time_max as time_max," +
           "monster.respawn_id," +
           "monster.move_distance," +
           "monster.itembag," +
           "monster.elemental_attribute, " +
           "monster.id," +
           "monster.guid " +
           "FROM " +
           "monster " +
           "INNER " +
           "JOIN " +
           "world_template " +
           "ON " +
           "monster.world = world_template.entry " +
           "INNER JOIN " +
           "monster_template " +
           "ON " +
           "monster.id = monster_template.id " +
            "WHERE world_template.name = '" + MonsterSpot.nameWorldFind + "' " +
           "ORDER BY monster.id";

        public string loadAllMonster =
            "SELECT monster_template.name FROM monster_template";

        public string nameMonster =
            "SELECT monster_template.id " +
            "FROM " +
            "monster_template " +
            "WHERE " +
            "monster_template.name = '" + MonsterSpot.nameMonster + "'";

        public string insertMonster =
            "INSERT INTO monster " +
            "(guid,server, id, world, x1, y1, x2, y2, direction, spawn_delay, spawn_distance, respawn_time_min, respawn_time_max, respawn_id, move_distance, elemental_attribute,itembag,disabled) " +
            "VALUES (" + MonsterSpot.guid + "," + MonsterSpot.server + ", " + MonsterSpot.id + ", " +
            "" + MonsterSpot.WorldID + ", " + MonsterSpot.x1 + ", " +
            "" + MonsterSpot.y1 + ", " + MonsterSpot.x2 + ", " +
            "" + MonsterSpot.y2 + ", " + MonsterSpot.direction + ", " +
            "" + MonsterSpot.spawn_delay + ", " + MonsterSpot.spawn_distance + ", " +
            "" + MonsterSpot.respawn_time_min + ", " + MonsterSpot.respawn_time_max + ", " +
            "" + MonsterSpot.respawn_id + ", " + MonsterSpot.move_distance + ", " +
            "" + MonsterSpot.elemental_attribute + ", DEFAULT, 0)";

        public string lastInsertMonsterGUID =
            "SELECT MAX(guid) FROM monster;";

        public string deleteMonster =
            "DELETE FROM monster WHERE guid = " + MonsterSpot.guid + " AND id = " + MonsterSpot.id + "";

        public string loadMonsterPerGuidID =
            "SELECT " +
            "monster.guid," +
            "monster.server," +
            "monster.id," +
            "monster.world," +
            "monster.x1," +
            "monster.y1," +
            "monster.x2," +
            "monster.y2," +
            "monster.direction," +
            "monster.spawn_delay," +
            "monster.spawn_distance," +
            "monster.respawn_time_min," +
            "monster.respawn_time_max," +
            "monster.respawn_id," +
            "monster.move_distance," +
            "monster.elemental_attribute," +
            "monster.itembag," +
            "monster.disabled " +
            "FROM " +
            "monster " +
            "WHERE " +
            "monster.guid = " + MonsterSpot.guid + " AND monster.id = " + MonsterSpot.id + "";

        public string loadGuildList =
            "SELECT guild_list.guid," +
            "guild_list.name," +
            "guild_list.emblem," +
            "guild_list.hostil," +
            "guild_list.alliance," +
            "guild_list.notice," +
            "guild_list.score " +
            "FROM " +
            "guild_list";

        public string loadGuildMembers =
            "SELECT " +
            "character_info.name,character_info.online," +
            "guild_members.ranking " +
            "FROM " +
            "character_info " +
            "INNER JOIN " +
            "guild_members ON character_info.guid = guild_members.char_id INNER JOIN guild_list ON guild_members.guild_id = guild_list.guid " +
            "WHERE " +
            "guild_list.guid = " + GuildManage.idGuild + "";
        public string loadAllServerList =
            "SELECT " +
            "server_list.server," +
            "server_list.code," +
            "server_list.name," +
            "server_list.port," +
            "server_list.ip," +
            "server_list.flag," +
            "server_list.online," +
            "server_list.default_world," +
            "server_list.default_x," +
            "server_list.default_y," +
            "server_list.type " +
            "FROM " +
            "server_list";
        public string addServer =
            "INSERT INTO server_list " +
            "(server, code, name, port, ip, flag, online, default_world, default_x, default_y, type) " +
            "VALUES " +
            "(" + CreaterServer.server + ", " + CreaterServer.code + ", '" + CreaterServer.name + "', " + CreaterServer.port + ", '" + CreaterServer.ip + "', " + CreaterServer.flag + ", 0 , " + CreaterServer.default_world + ", " + CreaterServer.default_x + ", " + CreaterServer.default_y + ", " + CreaterServer.type + ")";
        public string countPlayer =
            "SELECT COUNT(character_info.online) AS Online " +
            "FROM " +
            "character_info WHERE character_info.online = 1";

        public string loadAllMinimap =
            "SELECT " +
            "mini_map.world," +
            //"world_template.name," +
            "mini_map.`index`," +
            "mini_map.`group`," +
            "mini_map.type," +
            "mini_map.x," +
            "mini_map.y," +
            "mini_map.text," +
            "mini_map.server " +
            "FROM mini_map " +
            "INNER JOIN " +
            "world_template " +
            "ON " +
            "mini_map.world = world_template.entry " +
            "WHERE " +
            "mini_map.server = " + MiniMap.Server + " " +
            "AND " +
            "world_template.name = '" + MiniMap.MapName + "'";

        public string IDServerList =
            "SELECT " +
            "server_list.server " +
            "FROM " +
            "server_list";

        public string FindWorldEntry =
          "SELECT world_template.entry FROM world_template WHERE world_template.name = '" + MiniMap.MapName + "'";

        public string SaveMiniMap =
            "INSERT INTO " +
            "mini_map " +
            "(world, `index`, `group`, type, x, y, text, server) " +
            "VALUES " +
            "(" + MiniMap.WorldEntry + ", " + MiniMap.index + ", " + MiniMap.group + ", " + MiniMap.type + ", " + MiniMap.x + ", " + MiniMap.y + ", '" + MiniMap.text + "', " + MiniMap.Server + ")";

        public string LastIndexMiniMap =
            "SELECT " +
            "MAX(`index`) " +
            "FROM " +
            "mini_map " +
            "INNER " +
            "JOIN " +
            "world_template " +
            "ON " +
            "mini_map.world = world_template.entry " +
            "WHERE " +
            "mini_map.server = " + MiniMap.Server + " " +
            "AND " +
            "world_template.name = '" + MiniMap.MapName + "'";

        public string DeleteMiniMap =
            "DELETE FROM " +
            "mini_map " +
            "WHERE " +
            "server = " + MiniMap.Server + " " +
            "AND " +
            "`index` = " + MiniMap.index + "";

        public string UpdateMiniMap =
            "UPDATE " +
            "mini_map " +
            "SET " +
            "`group` = "+MiniMap.group+"," +
            "type = " + MiniMap.type+ "," +
            "x = " + MiniMap.x+ "," +
            "y = " + MiniMap.y+ "," +
            "text = '" + MiniMap.text+ "' " +
            "WHERE world = " + MiniMap.WorldEntry + " " +
            "AND " +
            "server = " + MiniMap.Server + " " +
            "AND `index` = " + MiniMap.index + "";
    }
}