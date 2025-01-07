using System;

[Serializable]
public class SayKitGameConfig
{
	public int none;

	public string support_email;

	public string discord_link;

	public string discord_link_announcements;

	public string discord_link_recruitment;

	public string global_announcement;

	public int transfer_error_panel_enabled;

	public int use_fixed_global_level_count;

	public int show_interstitials;

	public int no_interstitials_since_last_purchase;

	public string no_interstitials_if_first_version_lower_than;

	public int no_interstitials_before_global_level_index;

	public int inapp_server_verification_disabled;

	public string newest_version;

	public int newest_build;

	public int newest_version_cooldown;

	public int version_unsupported_timestamp;

	public int news_popup_autoshow;

	public int new_version_button_disabled;

	public int whats_new_blocks_amount;

	public int banned_account_cannot_play;

	public int cheater_cannot_access_clans;

	public int pause_seconds_from_background;

	public int gameplay_optimisations;

	public int game_dot_damage_cant_crit;

	public float game_ricochet_dmg_mul;

	public float revive_invulnrability_time;

	public int lc_lootboxgems_gems_min;

	public int lc_lootboxgems_gems_max;

	public string lc_lootbox_cooldown;

	public string lc_lootbox_drop_enemy_count;

	public string lc_lootbox_order;

	public float lc_bonus_droprate_from_pass;

	public string video_rewards_enabled;

	public int video_rewards_chest_limit_count;

	public int video_rewards_chest_reset_time;

	public string revive_counts;

	public string revive_price;

	public int revive_token_value;

	public int revive_for_tokens_disabled;

	public int general_ad_revive_count;

	public int general_ad_revive_first;

	public float general_revive_timer;

	public int general_timeskip_chest_max;

	public int general_timeskip_chest_time;

	public int general_min_unpicked_cash;

	public int general_claim_items_price;

	public int player_starting_inventory_slot_count;

	public int player_starting_inventory_slot_count_gear;

	public int player_starting_gems;

	public int player_tutorial_parts;

	public int player_tutorial_cash;

	public int player_invulnerable_enemies_dead;

	public float player_second_life_cd_rifts;

	public float player_second_life_cd_default;

	public float ultimate_charge_base_enemy;

	public float ultimate_charge_player_health;

	public float enemy_alert_hit_range;

	public float enemy_alert_death_range;

	public float enemy_alert_player_fire_range_multiplier;

	public float enemy_sight_range;

	public float enemy_looking_alert_multiplier;

	public string enemy_base_data;

	public float enemy_health_level_multiplier;

	public float enemy_health_level_exponent;

	public float enemy_health_extra_exponent;

	public int enemy_health_extra_exponent_start_level;

	public float enemy_damage_level_multiplier;

	public float enemy_convert_elite_chance;

	public float enemy_base_cp_multiplier;

	public float enemy_cp_level_exponent;

	public string nonboss_health_level_multiplier;

	public string nonboss_damage_level_multiplier;

	public string miniboss_health_level_multiplier;

	public string miniboss_damage_level_multiplier;

	public string hell_rifts_miniboss_bleed_resistance_multiplier;

	public string miniboss_name_counts;

	public string worlds;

	public string raid;

	public int raid_price_chest_boost;

	public int raid_price_auto_complete;

	public int raid_price_instant_chest;

	public int raid_freeplay_interval_long;

	public int raid_freeplay_interval_short;

	public int raid_freeplay_limit;

	public int raid_freeplay_start_timestamp;

	public string episodes;

	public string hell;

	public float raid_boss_player_min_health;

	public float raid_boss_chance;

	public int raid_boss_level_reduction;

	public string miniboss_stages;

	public int miniboss_breakpoint_weight;

	public int hell_miniboss_breakpoint_weight;

	public float hell_time_before_burn;

	public int dynamic_quality;

	public int hell_disabled;

	public int skirmish_start_timestamp;

	public int skirmish_interval;

	public string skirmish_gameplay_mode_sequence;

	public int skirmish_enemy_count;

	public float skirmish_enemy_convert_elite_chance;

	public string skirmish_modifier_value_weights;

	public int skirmish_max_positive_modifiers;

	public int skirmish_gamble_spin_again_price;

	public int skirmish_modifier_reroll_price_gems;

	public int skirmish_modifier_reroll_cap;

	public int skirmish_max_threat;

	public int skirmish_reroll_modifiers_on_threat_increase;

	public int skirmish_refresh_reroll_count_on_threat_increase;

	public string skirmish_enemy_level_offsets;

	public float skirmish_waves_threat_enemy_level_add;

	public int skirmish_waves_initial_wave_count;

	public string skirmish_waves_initial_spawn_weight;

	public int skirmish_waves_threat_spawn_weight_add;

	public int skirmish_bomb_initial_timer;

	public int skirmish_bomb_initial_stage_count;

	public int skirmish_bomb_threat_timer_rm;

	public float skirmish_bomb_threat_enemy_level_add;

	public int skirmish_bomb_initial_segment_count;

	public float skirmish_bomb_initial_segment_defuse_time;

	public int skirmish_classic_initial_stage_count;

	public float skirmish_classic_threat_enemy_level_add;

	public int skirmish_show_reroll_after_failed;

	public int skirmish_threat_skip_price;

	public int skirmish_autocomplete_quests_allowed;

	public int skirmish_autocomplete_quests_price;

	public int rifts_disabled;

	public int rift_start_timestamp;

	public int rift_regular_duration;

	public int rift_cooldown_duration;

	public int rift_finalizing_results_duration;

	public int rift_placement_duration;

	public int rift_first_season_index;

	public int rift_chest_level;

	public string rifts_min_version;

	public int rift_new_season_starting_floor_adjustment;

	public int weeklycontracts_enabled;

	public int weeklycontracts_start_timestamp;

	public int weeklycontracts_week_interval;

	public int weeklycontracts_day_interval;

	public int weeklycontracts_shop_interval;

	public int weeklycontracts_shop_memory;

	public int weeklycontracts_shop_list_size;

	public int weeklycontracts_daily_quest_count;

	public int weeklycontracts_weekly_progress_step;

	public string weeklycontracts_weekly_reward_requirements;

	public string weeklycontracts_weekly_rewards;

	public string weeklycontracts_weekly_rewards_increases;

	public int weeklycontracts_vip_extra_middleman_tokens;

	public int weeklycontracts_vip_extra_quests;

	public int weeklycontracts_quest_rerolls;

	public int weeklycontracts_quest_reroll_price;

	public int halloween_start;

	public int halloween_end;

	public int halloween_pass_bonus_tokens_small;

	public int halloween_pass_bonus_tokens_large;

	public int halloween_remind_interval;

	public int halloween_price_play_currency;

	public int halloween_price_play_gems;

	public string halloween_currency_acquire;

	public int halloween_daily_play_for_gems_limit;

	public int halloween_daily_play_for_gems_reset_interval;

	public int halloween_daily_buy_for_realmoney_limit;

	public int halloween_daily_buy_for_realmoney_reset_interval;

	public int halloween_daily_buy_for_realmoney_amount;

	public int halloween_bonus_device_gems;

	public int halloween_bonus_device_cash;

	public int halloween_bonus_device_tickets;

	public string halloween_game_level_offsets;

	public string halloween_game_scaling_level_offsets;

	public int halloween_daily_keys_free;

	public int halloween_daily_keys_superpremium;

	public float halloween_game_enemy_level_multiplier;

	public int halloween_game_enemy_level_multiplier_apply;

	public int halloween_game_tokens_regular;

	public int halloween_game_tokens_elite;

	public int halloween_game_tokens_giant;

	public string halloween_game_tokens_added_waves;

	public int halloween_daily_play_ad_enabled;

	public int halloween_daily_play_ad_limit;

	public int halloween_daily_play_ad_reset_interval;

	public int halloween_daily_play_ad_reset_interval_short;

	public int halloween_daily_play_ad_count;

	public int christmas_start;

	public int christmas_chests_appear_timestamp;

	public int christmas_gifts_claimable_timestamp;

	public int christmas_end;

	public int christmas_ending_interval;

	public string christmas_currency_acquire;

	public int christmas_progress_price_currency;

	public int christmas_progress_price_gems;

	public int christmas_purchasable_boost_amount;

	public int christmas_gem_boost_amount;

	public int christmas_purchase_pass_bonus_boosts;

	public int christmas_purchase_pass_bonus_boosts_small;

	public int christmas_daily_gem_boost_limit;

	public int christmas_daily_real_money_boost_limit;

	public int christmas_gem_boost_enabled;

	public int christmas_money_boost_enabled;

	public int christmas_base_raidticket_boost;

	public int christmas_base_gem_boost;

	public int christmas_base_cash_boost;

	public int christmas_extra_shard_amount;

	public int christmas_real_money_boost_reset_interval;

	public int christmas_gem_boost_reset_interval;

	public int christmas_chests_bonus_currency;

	public int christmas_ending_show_count;

	public int christmas_play_count_ads;

	public int christmas_play_enabled_ads;

	public int christmas_play_limit_ads;

	public int christmas_play_resetinterval_ads;

	public int christmas_play_resetinterval_ads_short;

	public int easter_start;

	public int easter_end;

	public string easter_currency_acquire;

	public string easter_board_config;

	public int easter_playprice_currency;

	public int easter_playprice_gems;

	public int easter_playcap_gems;

	public int easter_playcap_realmoney;

	public int easter_playcap_resetinterval_realmoney;

	public int easter_playcap_resetinterval_gems;

	public int easter_premiumbonus_small;

	public int easter_premiumbonus_large;

	public int easter_base_device_bonus_cash;

	public int easter_base_device_bonus_gems;

	public int easter_base_device_bonus_tickets;

	public int easter_plays_currency;

	public int easter_plays_gems;

	public int easter_plays_realmoney;

	public string disabled_bomb_stage_ids;

	public string disabled_waves_stage_ids;

	public string operations;

	public string operations_gen;

	public string operations_gen_scaling_offsets;

	public int operations_spinagain_gems;

	public int operations_price_instant;

	public int expedition_available_interval;

	public int expedition_key_refresh_interval;

	public int expedition_max_entries;

	public string expedition_generation_scaling_levelOffsets;

	public int expedition_max_level_step;

	public int expedition_min_level_step;

	public int expedition_start_timestamp;

	public int expedition_keycard_full_price;

	public int expedition_autocomplete_ticket_price;

	public int boost_wheel_spin_again_gems;

	public string loot_drop_table;

	public string loot_cash_min_max;

	public float loot_cash_elite_multiplier;

	public float loot_item_drop_percent;

	public float loot_scrap_drop_percent;

	public float loot_cash_drop_percent;

	public float loot_gem_drop_percent;

	public float loot_wrench_drop_percent;

	public float loot_cash_drop_multiplier;

	public float loot_item_drop_chance_stacking_increase;

	public float loot_elite_item_drop_multiplier;

	public float loot_wrench_drop_chance_stacking_increase;

	public float loot_drop_item_level_multiplier;

	public int loot_drop_item_level_addition_max;

	public float loot_drop_modifier_gm_kill_enemies;

	public float loot_drop_modifier_gm_bomb;

	public float loot_drop_modifier_gm_waves;

	public float loot_legendary_upgrade_chance;

	public int chests_gem_price_per_3_min;

	public int chests_epic_reward_interval;

	public int chests_instant_open_story;

	public float chest_boost_extra_multiplier_cash;

	public float chest_boost_extra_multiplier_scrap;

	public int chest_boost_gem_price;

	public int chest_boost_starting_free_boosts;

	public string chests_receive_order;

	public string chests_reward_overrides;

	public string chest_boostable_overrides;

	public string chest_boostable_x2_allowed;

	public int chest_purple_ltv_unlock_price;

	public string legendary_weapon_chest_reward_weights;

	public string weapon_chest_reward_weights;

	public string weapon_chest_featured_weights;

	public string agent_card_upgrade_data;

	public string agent_data_overrides;

	public string agent_level_brackets;

	public string agent_level_bracket_prices_cards;

	public string agent_level_bracket_prices_cash;

	public int agent_enhancement_upgrade_cash_price_base;

	public int agent_enhancement_upgrade_cash_price_scale;

	public int agent_enhancement_upgrade_level_requirement_scale;

	public int agent_enhancement_upgrade_level_requirement_base;

	public string weapon_max_levels;

	public string weapon_rank_upgrade_increments;

	public string weapon_dissassemble_rewards;

	public string weapon_salvage_parts_price;

	public int weapon_salvage_tool_price;

	public int weapon_salvage_popup_rarity;

	public string weapon_attribute_application_rules;

	public string weapon_attribute_config;

	public string weapon_upgrade_requirements;

	public string weapon_rankup_requirements;

	public string weapon_limitbreak_requirements;

	public string weapon_empower_requirements;

	public string weapon_scaling_regular;

	public string weapon_scaling_rank;

	public string weapon_scaling_limitbreak;

	public int weapon_scaling_empower;

	public int weapon_max_empower_level;

	public float weapon_rarities_scaling;

	public float weapon_scaling_exponent;

	public float weapon_itemlevel_scaling;

	public string weapon_upgrade_added_scrap;

	public string weapon_upgrade_added_cash;

	public int weapon_max_item_level;

	public int weapon_legendary_always_max;

	public float weapon_legendary_regular_bonus_roll_min;

	public float weapon_legendary_regular_bonus_roll_max;

	public string gear_bonus_config;

	public string gear_stats_config;

	public string gear_bonus_layouts;

	public string gear_bonus_quality_layouts;

	public string gear_bonus_rarity_qualities;

	public string gear_bonus_quality_growth;

	public string gear_stat_reroll_prices;

	public string gear_bonus_reroll_price;

	public string gear_bonus_reroll_price_maxed;

	public int gear_bonus_reroll_locked_price_multiplier;

	public string gear_upgrade_epic_added_levels;

	public string gear_upgrade_max_levels;

	public string gear_upgrade_price_scrap_brackets;

	public string gear_upgrade_price_cash_brackets;

	public string gear_upgrade_bonus_damage_brackets;

	public string gear_upgrade_bonus_health_brackets;

	public float heal_drop_chance;

	public float heal_amount_factor;

	public int remoteoffers_pull_interval;

	public int remoteoffers_popup_reopen_interval;

	public int remoteoffers_data_version;

	public string remoteoffers_ab_version;

	public int iap_testing_enable_all_offers;

	public int iap_remote_offers_override;

	public int iap_forcepopup_interval_long;

	public int iap_forcepopup_interval_short;

	public int iap_cash_pack_amount;

	public int iap_gem_pack_amount;

	public int iap_gem_pack_2_amount;

	public int iap_gem_pack_3_amount;

	public int iap_revive_pack_amount;

	public int iap_agent_shards_single_price;

	public string iap_gem_purchases;

	public string iap_scaling_cash_purchases;

	public int iap_resource_pack_1_cash;

	public int iap_resource_pack_2_cash;

	public int iap_resource_pack_3_cash;

	public int iap_resource_pack_4_cash;

	public int iap_resource_pack_1_gems;

	public int iap_resource_pack_2_gems;

	public int iap_resource_pack_3_gems;

	public int iap_resource_pack_4_gems;

	public int iap_scrap_pack_1_scrap;

	public int iap_scrap_pack_2_scrap;

	public int iap_scrap_pack_3_scrap;

	public int iap_scrap_pack_4_scrap;

	public int iap_one_time_offer_expired;

	public string iap_chest_prices;

	public int iap_starterpack_cash;

	public int iap_starterpack_gems;

	public int iap_starterpack_scrap;

	public int iap_starterpack_available_interval;

	public int iap_starterpack_weapon_level;

	public int iap_chestpack_gem_count;

	public int iap_chestpack_available_interval;

	public int iap_chestpack_reccur_interval;

	public int iap_limitbreakpack_gem_count;

	public int iap_limitbreakpack_available_interval;

	public int iap_limitbreakpack_reccur_interval;

	public int iap_agentsshardspack_min_empowers;

	public int iap_agentsshardspack_amount;

	public int iap_agentsshardspack_available_interval;

	public int iap_agentsshardspack_reccur_interval;

	public int iap_toolspack_gems_count;

	public int iap_toolspack_tools_count;

	public int iap_toolspack_available_interval;

	public int iap_toolspack_reccur_interval;

	public int iap_gemspack_first_purchase_bonus;

	public int iap_weekly_agent_shards_price;

	public int iap_weekly_gear_materials_price;

	public int iap_weekly_gear_boosters_price;

	public int iap_weekly_tools_price;

	public int iap_weekly_agent_shards_amount;

	public int iap_weekly_gear_materials_amount;

	public int iap_weekly_gear_boosters_amount;

	public int iap_weekly_tools_amount;

	public int iap_weekly_agent_shards_available;

	public int iap_weekly_gear_materials_available;

	public int iap_weekly_gear_boosters_available;

	public int iap_weekly_tools_available;

	public int iap_weekly_refresh_interval;

	public int iap_weapon_chest_refresh_interval;

	public int iap_upgrade_chest_refresh_interval;

	public int iap_legendary_chest_refresh_interval;

	public int iap_weapon_chest_first_epic_guaranteed;

	public int iap_legendary_chest_first_epic_guaranteed;

	public int iap_weekly_cash_bonus_start_timestamp;

	public int iap_weekly_cash_bonus_reset_interval;

	public int iap_blackfriday_cash_bonus_start_timestamp;

	public int iap_blackfriday_cash_bonus_end_timestamp;

	public int iap_blackfriday_gem_bonus_start_timestamp;

	public int iap_blackfriday_gem_bonus_end_timestamp;

	public float iap_weekly_cash_bonus_multiplier;

	public float iap_blackfriday_cash_bonus_multiplier;

	public float iap_blackfriday_gem_bonus_multiplier;

	public int iap_blackfriday_gem_index;

	public string iap_blackfriday_gem_offer_limits;

	public int iap_weapon_chest_token_price;

	public int iap_weapon_chest_select_opens_requirement;

	public int iap_minor_weapon_chest_select_opens_requirement;

	public int iap_weapon_chest_select_opens_requirement_firstTime;

	public string iap_weapon_chest_featured_skip_price;

	public string iap_weapon_chest_guarantees;

	public int iap_legendary_chest_gem_price;

	public int iap_legendary_chest_token_price;

	public int iap_legendary_chest_select_opens_requirement;

	public int iap_legendary_chest_minor_select_opens_requirement;

	public int iap_legendary_chest_first_open_bonus_enabled;

	public int iap_legendary_chest_first_try_bonus_multiplier;

	public string iap_legedary_chest_featured_skip_price;

	public string iap_legendary_chest_guarantees;

	public string iap_resource_chest_config;

	public int iap_resource_chest_token_price;

	public int iap_resource_chest_refresh_interval;

	public string iap_weaponpart_chest_config;

	public int iap_weaponpart_chest_token_price;

	public int iap_weaponpart_chest_select_part_uncommon_opens;

	public int iap_weaponpart_chest_select_part_exceptional_opens;

	public int iap_weaponpart_chest_select_part_Rare_opens;

	public int iap_weaponpart_chest_select_part_Epic_opens;

	public int iap_weaponpart_chest_refresh_interval;

	public int iap_weaponpart_chest_select_part_start;

	public int iap_materialsMegaBundle_availabel_interval;

	public int iap_materialsMegaBundle_gemsAmount;

	public int iap_materialsMegaBundle_materialsAmount;

	public int iap_materialsMegaBundle_cashAmount;

	public int iap_materialsMegaBundle_reccurInterval;

	public int iap_lmgpack_duration;

	public int iap_lmgpack_recur_interval;

	public int iap_lmgpack_cashAmount;

	public int iap_lmgpack_scrapAmount;

	public int iap_raidoffer_duration;

	public int iap_raidoffer_recur_interval;

	public int iap_raidoffer_ticketAmount;

	public int iap_tripleOffer_duration;

	public int iap_tripleOffer_recur_interval;

	public int iap_blackfriday_start;

	public int iap_blackfriday_duration;

	public int iap_blackfriday_recur_interval;

	public int iap_cashoffer_cash_amount;

	public int iap_cashoffer_duration;

	public int iap_cashoffer_recur_interval;

	public string iap_vip_skingrants;

	public int iap_vip_offer_show_interval_days;

	public int iap_vip_special_offer_duration;

	public int iap_vip_freevip_enabled;

	public int iap_vip_freevip_duration;

	public int iap_vip_reusable_special_start;

	public int iap_vip_reusable_special_end;

	public int iap_vip_reusable_special_index;

	public string iap_vip_reusable_special_enabled_types;

	public int iap_pass_hidden_from_lvl;

	public int iap_resources_hidden_from_lvl;

	public int iap_weekenddeal_reveal1_cash_price;

	public int iap_weekenddeal_reveal2_cash_price;

	public int iap_weekenddeal_reveal3_cash_price;

	public int iap_weekenddeal_reveal4_cash_price;

	public int iap_weekenddeal_nogen_duration;

	public int iap_weekenddeal_duration_full;

	public int iap_weekenddeal_startTimestamp;

	public int iap_weekenddeal_daily_purchase_limit;

	public int iap_weekenddeal_single_offer_duration;

	public string iap_weekenddeal_offer_layouts;

	public int iap_gearbooster_booster_amount;

	public int iap_gearbooster_gearfragment_amount;

	public int iap_gearbooster_cash_amount;

	public int iap_gearbooster_duration;

	public int iap_gearbooster_cooldown;

	public int iap_gearbooster_accountlvl_unlock;

	public int iap_special_cash_offer_start_timestamp;

	public int iap_special_cash_offer_end_timestamp;

	public float iap_special_cash_offer_multiplier;

	public string iap_ads_reset_intervals;

	public int iap_ads_claims_per_reset;

	public int iap_ads_full_reset_interval;

	public int iap_dailyoffer_gemcount;

	public int iap_dailyoffer_cooldown;

	public int iap_dailyoffer_claims;

	public string iap_ads_cash_amount_scaling;

	public string iap_default_prices;

	public string iap_blocked_offers;

	public int iap_skinoffers_start_timestamp;

	public int iap_skinoffers_offer_count;

	public int iap_skinoffers_reset_interval;

	public string iap_skinoffers_possible_discounts;

	public int iap_skinoffers_possible_price;

	public string ads_fulfillable_loot;

	public int ads_fulfillable_loot_reset_start;

	public int inventory_expand_slot_price;

	public int inventory_expand_step_price_increase;

	public int inventory_expand_step_size;

	public int inventory_max_size;

	public int pass_xp_gain_regular;

	public int pass_xp_gain_regular_boss;

	public int pass_xp_gain_raid;

	public int pass_xp_gain_operations;

	public int pass_xp_gain_expeditions;

	public string pass_xp_gain_skirmish;

	public int pass_xp_gain_hell;

	public int pass_time_start;

	public int pass_level_xp_requirement;

	public int pass_level_skip_price;

	public int pass_ending_notification;

	public int pass_bonus_safe_max_claims;

	public int pass_bonus_cash_per_level;

	public int pass_bonus_safe_refill_price;

	public int pass_bonus_cash_per_level_purchased;

	public int pass_bonus_cash_per_level_premium;

	public int pass_premium_level_skip;

	public int pass_final_skip_enabled;

	public int arcadepass_start_timestamp;

	public int arcadepass_season_duration;

	public int arcadepass_remind_interval;

	public int arcadepass_reward_claim_duration;

	public string arcadepass_currency_acquire;

	public int arcadepass_play_price_currency;

	public int arcadepass_play_price_gems;

	public int arcadepass_play_enabled_gems;

	public int arcadepass_play_enabled_realmoney;

	public int arcadepass_play_enabled_ads;

	public int arcadepass_play_count_currency;

	public int arcadepass_play_count_gems;

	public int arcadepass_play_count_realmoney;

	public int arcadepass_play_count_ads;

	public int arcadepass_play_count_pass;

	public int arcadepass_play_count_passlarge;

	public int arcadepass_play_resetinterval_gems;

	public int arcadepass_play_resetinterval_realmoney;

	public int arcadepass_play_resetinterval_ads;

	public int arcadepass_play_resetinterval_ads_short;

	public int arcadepass_play_limit_gems;

	public int arcadepass_play_limit_realmoney;

	public int arcadepass_play_limit_ads;

	public float arcadepass_currency_premium_droprate_multiplier;

	public int starterevent_allowed;

	public int starterevent_season_duration;

	public int starterevent_remind_interval;

	public int starterevent_reward_claim_duration;

	public string starterevent_currency_acquire;

	public int starterevent_play_price_currency;

	public int starterevent_play_price_gems;

	public int starterevent_play_enabled_gems;

	public int starterevent_play_enabled_realmoney;

	public int starterevent_play_enabled_ads;

	public int starterevent_play_count_currency;

	public int starterevent_play_count_gems;

	public int starterevent_play_count_realmoney;

	public int starterevent_play_count_ads;

	public int starterevent_play_count_pass;

	public int starterevent_play_count_passlarge;

	public int starterevent_play_resetinterval_gems;

	public int starterevent_play_resetinterval_realmoney;

	public int starterevent_play_resetinterval_ads;

	public int starterevent_play_resetinterval_ads_short;

	public int starterevent_play_limit_gems;

	public int starterevent_play_limit_realmoney;

	public int starterevent_play_limit_ads;

	public float starterevent_currency_premium_droprate_multiplier;

	public string account_xp_requirements;

	public string account_xp_predefined_story_gains;

	public int account_xp_per_loot_level;

	public string account_xp_specop_diff_mul;

	public float account_xp_skirmish_mul;

	public float account_xp_expedition_mul;

	public float account_xp_boss_mul;

	public int account_unlocklvl_shop_dailies;

	public int account_unlocklvl_operations;

	public int account_unlocklvl_operations_hard;

	public int account_unlocklvl_operations_extreme;

	public int account_unlocklvl_expeditions;

	public int account_unlocklvl_raids;

	public int account_unlocklvl_workshop;

	public int account_unlocklvl_loadout_2;

	public int account_unlocklvl_loadout_3;

	public int account_unlocklvl_loadout_4;

	public int account_unlocklvl_skirmish;

	public int account_unlocklvl_rifts;

	public int account_unlocklvl_clans;

	public int account_unlocklvl_base;

	public int account_unlocklvl_global_tab;

	public int account_unlocklvl_legendarychest;

	public int account_unlocklvl_shards_offer;

	public int account_unlocklvl_weeklycontracts;

	public int account_grant_xp_rewards_lower_hunt;

	public int account_discord_popup_show_interval;

	public float account_story_multiplier;

	public float account_hell_multiplier;

	public int account_raid_unlock_ticket_reward;

	public int account_workshop_unlock_fragment_reward;

	public int account_starting_gems;

	public int account_discord_join_gems;

	public int account_first_login_reward_gems;

	public string notifbubbles_disabled;

	public int timers_revive_ad_reset;

	public int timers_shop_daily_reset;

	public int timers_operation_reset;

	public int timers_discount_available;

	public int notifier_openchest_enabled;

	public int notifier_newoperations_enabled;

	public int notifier_skirmish_enabled;

	public int notifier_dailyshop_enabled;

	public int notifier_expeditiontickets_enabled;

	public int notifier_rift_seasonstart_enabled;

	public int notifier_rift_seasonend_enabled;

	public int notifier_rift_seasonend_timeuntil;

	public int notifier_ios_chest_open_interval;

	public int notifier_clan_donation_enabled;

	public int notifier_clan_assist_enabled;

	public int notifier_clan_mission_started_enabled;

	public int notifier_clan_mission_ending_enabled;

	public int workshop_max_level;

	public string workshop_xp_requirements;

	public string workhshop_gear_rarity_craft_weights;

	public int workshop_free_crafts_gear_body;

	public string workshop_fuse_cash_prices;

	public int cloud_sign_in_popup_min_world;

	public int cloud_versioning_disabled;

	public int auto_quality_from_fps_enabled;

	public int auto_quality_from_fps_avg;

	public int tutorial_disable_non_gameplay_part;

	public int tutorial_upgrade_levelcompleted;

	public int shop_require_network;

	public string base_xp_requirements;

	public string base_locker_percentages;

	public string base_levelup_rewards;

	public string base_devices_config;

	public string default_base_styles;

	public string base_xp_prestige_hammers;

	public string base_prestige_rewards;

	public int base_blueprint_duplicate_req;

	public int base_default_hammers;

	public int base_tutorial_token_reward;

	public string base_initial_blueprints;

	public int base_token_price_in_gems;

	public int base_token_bundle_price_in_gems;

	public string base_iap_hammers_offers;

	public string base_iap_hammers_offers_prices;

	public int base_unload_items_on_exit;

	public int base_vip_daily_hammers;

	public string base_duplicates_per_rarity_value;

	public string base_banned_objects;

	public int base_order_items_by_price;

	public int base_device_pulsing;

	public int base_claim_destruction_hammers;

	public int base_check_for_bad_item;

	public string base_room_unlock_levels;

	public string base_room_unlock_order;

	public int base_style_cost;

	public int base_room_build_time;

	public int base_expansion_popup_enabled;

	public int mrbit_event_start;

	public int mrbit_event_duration;

	public int mrbit_event_refresh;

	public float mrbit_event_currency_drop_rate;

	public float mrbit_event_currency_drop_rate_lootbox;

	public float mrbit_event_currency_drop_rate_miniboss;

	public int mrbit_event_currency_chest_drop_silver_min;

	public int mrbit_event_currency_chest_drop_silver_max;

	public int mrbit_event_currency_chest_drop_green_min;

	public int mrbit_event_currency_chest_drop_green_max;

	public int mrbit_event_currency_chest_drop_red_min;

	public int mrbit_event_currency_chest_drop_red_max;

	public int mrbit_event_currency_chest_drop_purple_min;

	public int mrbit_event_currency_chest_drop_purple_max;

	public int mrbit_event_currency_expedition_chest_drop_medium_min;

	public int mrbit_event_currency_expedition_chest_drop_medium_max;

	public int mrbit_event_currency_expedition_chest_drop_large_min;

	public int mrbit_event_currency_expedition_chest_drop_large_max;

	public int mrbit_event_currency_chest_boost_extra_multiplier;

	public int mrbit_event_currency_drop_amount_min;

	public int mrbit_event_currency_drop_amount_max;

	public float mrbit_event_currency_drop_miniboss_multiplier;

	public int mrbit_event_currency_drop_lootbox_op_easy_min;

	public int mrbit_event_currency_drop_lootbox_op_easy_max;

	public int mrbit_event_currency_drop_lootbox_op_medium_min;

	public int mrbit_event_currency_drop_lootbox_op_medium_max;

	public int mrbit_event_currency_drop_lootbox_op_hard_min;

	public int mrbit_event_currency_drop_lootbox_op_hard_max;

	public int mrbit_event_currency_drop_lootbox_op_extreme_min;

	public int mrbit_event_currency_drop_lootbox_op_extreme_max;

	public int mrbit_event_daily_roll_for_gems_limit;

	public int mrbit_event_daily_roll_for_gems_reset_interval;

	public string mrbit_event_milestones;

	public int mrbit_event_increase_gem_roll_price_per_roll;

	public string mrbit_event_tile_rewards;

	public int mrbit_event_roll_cost_cards;

	public int mrbit_event_roll_cost_gems;

	public string mrbit_event_device_boost;

	public int mrbit_event_shard_increase;

	public int mrbit_event_pass_boost;

	public string mrbit_event_buy_pass_popup_after_free_claims;

	public int mrbit_event_button_roll_state_threshold;

	public int mrbit_event_operation_gamble_rare_reward_double_chance;

	public int mrbit_event_data_index;

	public int clan_settings_btn_enabled;

	public int clan_leader_auto_transfer_enabled;

	public int clan_create_price;

	public int clan_disabled;

	public int clan_chat_disabled;

	public int profanity_filter;

	public int clan_max_activity;

	public int clan_new_player_seconds;

	public int clan_update_frequency;

	public int clan_bots_disabled;

	public string clan_donation_inapp_bonuses;

	public string clan_settings_min_player_level_limits;

	public float clan_chest_multiplier_gear_fragments;

	public float clan_chest_multiplier_resource_tokens;

	public float clan_chest_multiplier_weapon_tokens;

	public float clan_chest_multiplier_agent_cards;

	public string clan_search_min_clan_level_limits;

	public int clan_missions_unlock_level;

	public int clan_league_tickets_purchase_amount;

	public int clan_league_tickets_discounted_purchases;

	public int clan_mission_miniboss_breakpoint_weight;

	public int clan_honor_shop_skin_count;

	public string base_styles_with_progress;

	public string base_styles_with_gems;

	public int mail_expiry_show_from;

	public int mail_disabled;

	public int mail_reward_max_gems;

	public int mail_menu_refresh_delay;

	public string mission_booster_values;

	public int clans_use_fetch_rpc;

	public int data_conflict_log_enabled;

	public int out_of_bounds_check_disabled;
}
