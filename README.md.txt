# Roteiro de Desenvolvimento de Jogo ARPG: Long Sword

## Visão Geral do Projeto
Este plano de desenvolvimento é focado na criação de um ARPG indie, inspirado em sucessos como Hades (Supergiant Games) e Path of Exile (Grinding Gear Games). O objetivo é manter um escopo realista para um desenvolvedor solo, com foco em prototipagem rápida, testes frequentes e um gameplay loop viciante. A estratégia adota o uso de assets prontos da Unreal Engine para acelerar o desenvolvimento inicial, priorizando a implementação de mecânicas e sistemas robustos.

## Milestones Principais
* **Protótipo Jogável (Vertical Slice):** Metas 1-80 – Foco nas mecânicas base, 1 ato, 5 skills, 6 inimigos e loot inicial.
* **Alpha Técnico:** Metas 81-180 – Expansão para 4 atos, sistemas robustos, save na nuvem e multiplayer local opcional.
* **Beta de Conteúdo:** Metas 181-280 – Expansão para 6 atos, mais de 30 inimigos, mais de 60 skills, quests narrativas ramificadas e o loop de end-game.
* **Polimento e Otimização:** Metas 281-350 – Finalização de arte e SFX, otimização de performance e foco em acessibilidade.
* **Testes e Lançamento:** Metas 351-380 – Testes Alpha/Beta com a comunidade e execução do plano de marketing.
* **Pós-Lançamento:** Metas 381-400 – Suporte contínuo, atualizações de conteúdo e engajamento com a comunidade.

---

## Fase 1: Protótipo Inicial e Fundações (Metas 1-100)
*O objetivo desta fase é criar um "vertical slice" jogável, estabelecendo as mecânicas centrais de combate, progressão e loot. A inspiração é o desenvolvimento inicial de Hades, com foco em um gameplay loop divertido e responsivo.*

### 1.1 - Setup e Mecânicas Básicas (Metas 1-30)
* [x] **Meta 1:** Setup inicial - Instalar UE, VS, Git; criar repo com README de objetivos e backlog inicial.
* [x] **Meta 2:** Criar projeto C++ básico com template Third Person; compilar, rodar, ativar plugins essenciais (Enhanced Input, Gameplay Debugger).
* [x] **Meta 3:** Implementar movimento e câmera (top-down/isométrica ajustável); testar edge cases como walls.
* [x] **Meta 4:** Adicionar animações placeholders (Mannequin) e assets temporários do Marketplace; documentar pipeline de substituição.
* [x] **Meta 5:** Sistema de ataque melee básico com hit detection (traces), dano simples, cooldown.
* [x] **Meta 6:** Criar inimigo simples com AI básica (Behavior Tree: patrulha, detecção, perseguição, ataque).
* [x] **Meta 7:** Implementar drop/loot simples (Actor spawn ao morrer) e coleta básica.
* [x] **Meta 8:** Inventário mínimo com HUD (UMG grid, barra de vida, tooltips iniciais).
* [ ] **Meta 9:** Salvamento persistência básica (SaveGame para stats, inventário, posição); testar load.
* [ ] **Meta 10:** Sistema de habilidades base - USkill class com custo/mana, 1 skill protótipo (projétil).
* [ ] **Meta 11:** Balance inicial - Ajustar dano/HP/cooldowns; adicionar partículas placeholders.
* [ ] **Meta 12:** Level design inicial - Arena pequena com obstáculos; spawn 2 inimigos variados.
* [ ] **Meta 13:** Progressão básica – XP system ligado a kills, level-up simples.
* [ ] **Meta 14:** Diálogo protótipo – UI para textos/choices; trigger no mapa.
* [ ] **Meta 15:** Playtest 30-60 min – Anotar 10 bugs; atualizar backlog.
* [ ] **Meta 16:** Refatorar para modularidade – UHealthComponent reutilizável.
* [ ] **Meta 17:** Sons placeholders (UE free assets); feedback audio básico.
* [ ] **Meta 18:** Testar Shipping build; otimizar draw calls iniciais.
* [ ] **Meta 19:** Documentar systems no README (ex: adding new enemy).
* [ ] **Meta 20:** Merge features para develop; playtest completo protótipo.
* [ ] **Meta 21:** Adicionar dash/movement especial; inspirado em Hades' mobility.
* [ ] **Meta 22:** Skill 2 protótipo (área dano); testar sinergia com melee.
* [ ] **Meta 23:** Inimigo 2 (ranged); Behavior Tree expandido.
* [ ] **Meta 24:** Loot data-driven (DataTable para itens/raridades).
* [ ] **Meta 25:** HUD cooldown visuals; ícones animados.
* [ ] **Meta 26:** Playtest combate loop; ajustar pacing.
* [ ] **Meta 27:** Salvar progressão expandida (inclua XP).
* [ ] **Meta 28:** Diálogo com choices afetando flags simples.
* [ ] **Meta 29:** Otimização inicial pooling (inimigos/itens).
* [ ] **Meta 30:** Milestone: Vertical slice jogável; gravar demo vídeo para feedback precoce.

### 1.2 - Estabilização e Expansão de Sistemas (Metas 31-100)
* [ ] **Meta 31:** Revisar bugs pendentes; branch estabilização.
* [ ] **Meta 32:** Melhorar input (gamepad support early); edge cases movimento.
* [ ] **Meta 33:** Hit detection avançada com debug visuals, multi-hits.
* [ ] **Meta 34:** Tests manuais para health/damage; adicionar resistências básicas.
* [ ] **Meta 35:** AI state machine (flee quando low HP); inspirado em Hades' enemy variety.
* [ ] **Meta 36:** Pooling expandido para projectiles/skills.
* [ ] **Meta 37:** Playtest 1h focado AI; balance agressividade.
* [ ] **Meta 38:** JSON/DataTable para itens; parser loader.
* [ ] **Meta 39:** Raridades (Common-Rare-Epic-Legendary); UI tooltips dinâmicos.
* [ ] **Meta 40:** Drop tables por enemy type; visuals spawn.
* [ ] **Meta 41:** Inventário: Equipar/descartar; stats apply on equip.
* [ ] **Meta 42:** Affixes iniciais (prefix/suffix); random gen.
* [ ] **Meta 43:** Damage formulas com mods (ex: crit chance).
* [ ] **Meta 44:** Playtest loot loop; ajustar drop rates como PoE early.
* [ ] **Meta 45:** USkill expandida – Cast time, range, multi-target.
* [ ] **Meta 46:** Skill 3 (buff/debuff); status effects component.
* [ ] **Meta 47:** Cooldowns com mana regen system.
* [ ] **Meta 48:** Feedback: Screen shake, hit stops (Hades-style).
* [ ] **Meta 49:** Playtest skills; refinar combos.
* [ ] **Meta 50:** XP thresholds; level-up UI notifications.
* [ ] **Meta 51:** Atributos tela; link a mecânicas (força=dano, int=mana).
* [ ] **Meta 52:** Passive tree protótipo (10 nodes); sinergias básicas.
* [ ] **Meta 53:** Persistir atributos no save; test corruption.
* [ ] **Meta 54:** Balance XP gain; rewards por quests.
* [ ] **Meta 55:** UI XP bar animada.
* [ ] **Meta 56:** Playtest progressão; ajustar curve.
* [ ] **Meta 57:** Ato 1 layout; zones, spawns.
* [ ] **Meta 58:** Encounters variados (groups enemies).
* [ ] **Meta 59:** Pickups (potions); checkpoints save.
* [ ] **Meta 60:** Quest simples (kill/fetch); log UI.
* [ ] **Meta 61:** Playtest Ato 1; mark flow issues.
* [ ] **Meta 62:** Merge Ato 1; version control assets.
* [ ] **Meta 63:** Inimigo 3 (telegraphed attacks com indicators como Hades).
* [ ] **Meta 64:** Animações state (Blend Spaces, Montages).
* [ ] **Meta 65:** Balance enemies HP/dano.
* [ ] **Meta 66:** Spawn heuristics anti-camping.
* [ ] **Meta 67:** Otimização draw calls; profile UE.
* [ ] **Meta 68:** Playtest enemy variety.
* [ ] **Meta 69:** Diálogo system JSON; nodes ramificados.
* [ ] **Meta 70:** Map triggers para cutscenes.
* [ ] **Meta 71:** Choices afetam quests/outcomes (Hades narrative style).
* [ ] **Meta 72:** Journal integrado; updates auto.
* [ ] **Meta 73:** Test narrative flow Ato 1.
* [ ] **Meta 74:** UX ajustes (text speed, wrap).
* [ ] **Meta 75:** Playtest narrativa.
* [ ] **Meta 76:** Consolidar vertical slice expandido.
* [ ] **Meta 77:** Bug fix críticos; sanity tests.
* [ ] **Meta 78:** Build teste outro PC.
* [ ] **Meta 79:** Documentar APIs/components.
* [ ] **Meta 80:** Feedback 3 testers; anotar changes.
* [ ] **Meta 81:** Aplicar quick fixes; balance.
* [ ] **Meta 82:** Merge vertical slice.
* [ ] **Meta 83:** Ato 2 theme (floresta); layout procedural básico.
* [ ] **Meta 84:** 5 novos inimigos Ato 2 (cooperativos packs).
* [ ] **Meta 85:** 3 novas skills (sinergia ambiental).
* [ ] **Meta 86:** Encounters Ato 2; test.
* [ ] **Meta 87:** Ato 3 (ruínas); puzzles integrados skills.
* [ ] **Meta 88:** Mais inimigos/quests Ato 3.
* [ ] **Meta 89:** Side-quests ramificadas.
* [ ] **Meta 90:** Mini-boss phased.
* [ ] **Meta 91:** Checkpoints inter-atos.
* [ ] **Meta 92:** Affixes expandidos; sockets itens.
* [ ] **Meta 93:** Crafting básico UI (combine recursos).
* [ ] **Meta 94:** Vendor NPC; currency system.
* [ ] **Meta 95:** Economy balance inicial.
* [ ] **Meta 96:** Stress test loot (memory checks).
* [ ] **Meta 97:** Document data tables.
* [ ] **Meta 98:** Dev console comandos (cheats).
* [ ] **Meta 99:** Asset pipeline placeholders → finals.
* [ ] **Meta 100:** Settings menu (res, keys); test.

---

## Fase 2: Expansão de Conteúdo e Narrativa (Metas 101-200)
*Com a base do jogo sólida, esta fase foca em escalar o conteúdo, aprofundar a narrativa e introduzir a complexidade de end-game, inspirada na profundidade de Path of Exile e nas recompensas narrativas de Hades.*

* [ ] **Meta 101:** Mecânica única: Eco-skills (alteram ambiente persistent).
* [ ] **Meta 102:** Integrar eco-skills levels.
* [ ] **Meta 103:** Balance eco; playtest impacto.
* [ ] **Meta 104:** Ato 4 (subterrâneo); puzzles complexos.
* [ ] **Meta 105:** 6 novos inimigos com IA avançada.
* [ ] **Meta 106:** Quests principais Ato 4 ramificadas.
* [ ] **Meta 107:** Diálogos com voice placeholders.
* [ ] **Meta 108:** Playtest Ato 4.
* [ ] **Meta 109:** Ato 5 (climax); boss rush.
* [ ] **Meta 110:** Boss final multi-phase, weak points.
* [ ] **Meta 111:** Endings alternativos choices-based.
* [ ] **Meta 112:** Lore via collectibles (journals).
* [ ] **Meta 113:** Passive tree expandido (20+ nodes, branches).
* [ ] **Meta 114:** Skills totais 15+; modulares variations.
* [ ] **Meta 115:** Sinergia system (combo buffs).
* [ ] **Meta 116:** Balance mid-game.
* [ ] **Meta 117:** Factions NPCs; reputation mech.
* [ ] **Meta 118:** Faction quests exclusive rewards.
* [ ] **Meta 119:** Procedural gen rooms (replayability como PoE maps).
* [ ] **Meta 120:** Test procedural; adjust randomness.
* [ ] **Meta 121:** Elites enemies com random modifiers.
* [ ] **Meta 122:** End-game loot uniques com lore.
* [ ] **Meta 123:** Crafting avançado (reforge, enchant).
* [ ] **Meta 124:** Economy balance end-game.
* [ ] **Meta 125:** Playtest full campaign 3h.
* [ ] **Meta 126:** Refinar diálogos imersão (branching deep).
* [ ] **Meta 127:** Side-stories opcionais.
* [ ] **Meta 128:** Adaptive music (zone/combate changes).
* [ ] **Meta 129:** SFX placeholders eventos narrativos.
* [ ] **Meta 130:** Test narrative full flow.
* [ ] **Meta 131:** Achievements system.
* [ ] **Meta 132:** UI achievements/stats.
* [ ] **Meta 133:** HUD mini-map dinâmico.
* [ ] **Meta 134:** Tooltips com lore interativos.
* [ ] **Meta 135:** Main menu polido (new/load).
* [ ] **Meta 136:** Multi-saves support.
* [ ] **Meta 137:** Otimizar load times async.
* [ ] **Meta 138:** Playtest conteúdo.
* [ ] **Meta 139:** Feedback beta testers 5+.
* [ ] **Meta 140:** Iterar quests feedback.
* [ ] **Meta 141:** Difficulty modes (normal/hard/nightmare).
* [ ] **Meta 142:** Balance por difficulty.
* [ ] **Meta 143:** New Game+ scaling.
* [ ] **Meta 144:** Leaderboards locais (speedruns).
* [ ] **Meta 145:** Test replayability.
* [ ] **Meta 146:** Inimigos totais 25+; variants.
* [ ] **Meta 147:** Skills 40+ com upgrade trees.
* [ ] **Meta 148:** Mecânica soul-binding (link skills itens custom).
* [ ] **Meta 149:** Balance soul-binding.
* [ ] **Meta 150:** Playtest custom builds.
* [ ] **Meta 151:** Document all systems wiki interno.
* [ ] **Meta 152:** Milestone: Beta conteúdo; full playthrough.
* [ ] **Meta 153:** Sprints extra content (DLC ideas).
* [ ] **Meta 154:** Random events mundo.
* [ ] **Meta 155:** Factions wars mech.
* [ ] **Meta 156:** Daily quests end-game.
* [ ] **Meta 157:** Balance end-loop.
* [ ] **Meta 158:** Multiplayer co-op básico (local).
* [ ] **Meta 159:** Test co-op sync.
* [ ] **Meta 160:** Pets/companions como unique mech.
* [ ] **Meta 161:** AI companions.
* [ ] **Meta 162:** Playtest companions.
* [ ] **Meta 163:** Narrative multi-playthroughs reativa.
* [ ] **Meta 164:** Diálogos player choices reativos.
* [ ] **Meta 165:** Voice text-to-speech temp.
* [ ] **Meta 166:** Test imersão.
* [ ] **Meta 167:** Collectibles rewards.
* [ ] **Meta 168:** World map interativo.
* [ ] **Meta 169:** Fast travel.
* [ ] **Meta 170:** Balance pacing jogo.
* [ ] **Meta 171:** Playtest full 8h.
* [ ] **Meta 172:** Iterar pacing.
* [ ] **Meta 173:** Secrets/easter eggs.
* [ ] **Meta 174:** Lore books in-game.
* [ ] **Meta 175:** Integrar concept art inicial.
* [ ] **Meta 176:** Test thematic consistency.
* [ ] **Meta 177:** Quests totais 60+; complex branches.
* [ ] **Meta 178:** Playtest quests.
* [ ] **Meta 179:** Document narrative design doc.
* [ ] **Meta 180:** Revisão conteúdo.
* [ ] **Meta 181:** Ato 6 end-game (infinite mode como PoE).
* [ ] **Meta 182:** Procedural maps avançados.
* [ ] **Meta 183:** Bosses rotativos.
* [ ] **Meta 184:** Loot tiers end-game.
* [ ] **Meta 185:** Balance infinite scaling.
* [ ] **Meta 186:** Playtest end-game loop.
* [ ] **Meta 187:** Adicionar mod support data.
* [ ] **Meta 188:** Test mods básicos.
* [ ] **Meta 189:** Expandir factions alliances.
* [ ] **Meta 190:** Quests faction wars.
* [ ] **Meta 191:** Skills faction-specific.
* [ ] **Meta 192:** Balance cross-faction.
* [ ] **Meta 193:** Narrative twists baseados factions.
* [ ] **Meta 194:** Playtest narrative depth.
* [ ] **Meta 195:** Adicionar voice lines narrativas.
* [ ] **Meta 196:** Test emotional impact (Hades style).
* [ ] **Meta 197:** Iterar dialogues polish.
* [ ] **Meta 198:** Full content audit.
* [ ] **Meta 199:** Prepare polimento phase.
* [ ] **Meta 200:** Milestone: Conteúdo completo, pronto polir.

---

## Fase 3: Polimento Técnico, Arte e Otimização (Metas 201-300)
*Esta fase é dedicada a transformar o jogo de um protótipo funcional em um produto profissional e polido, com atenção aos detalhes artísticos, sonoros e de performance, seguindo a filosofia da Supergiant Games.*

* [ ] **Meta 201:** Lista assets finals (chars, enemies, envs, VFX, SFX).
* [ ] **Meta 202:** Setup Blender integration UE; model basics.
* [ ] **Meta 203:** Substituir char mesh/anims.
* [ ] **Meta 204:** Retarget anims finals.
* [ ] **Meta 205:** Substituir enemies 1-10.
* [ ] **Meta 206:** Custom tilesets envs.
* [ ] **Meta 207:** VFX advanced (trails, explosions).
* [ ] **Meta 208:** SFX custom (Audacity/free).
* [ ] **Meta 209:** Original music (compose/hire).
* [ ] **Meta 210:** Adaptive audio impl.
* [ ] **Meta 211:** Profiling CPU/GPU UE.
* [ ] **Meta 212:** Reduce loads async.
* [ ] **Meta 213:** LODs all assets.
* [ ] **Meta 214:** Gamepad full support.
* [ ] **Meta 215:** Key remap.
* [ ] **Meta 216:** Accessibility: Color blind, text scale.
* [ ] **Meta 217:** Subtitles dialogues.
* [ ] **Meta 218:** UI anims/responsiveness.
* [ ] **Meta 219:** HUD options (minimalist).
* [ ] **Meta 220:** Test low-end hardware.
* [ ] **Meta 221:** Bug hunt checklists systems.
* [ ] **Meta 222:** Auto tests UE scripts.
* [ ] **Meta 223:** Substituir enemies 11-20.
* [ ] **Meta 224:** Envs atos 1-3.
* [ ] **Meta 225:** VFX skills únicas.
* [ ] **Meta 226:** SFX ambientais.
* [ ] **Meta 227:** Visual balance (lighting post-process).
* [ ] **Meta 228:** Playtest arte parcial.
* [ ] **Meta 229:** Iterar visual feedback.
* [ ] **Meta 230:** Voice acting final (record/hire).
* [ ] **Meta 231:** Integrar voice.
* [ ] **Meta 232:** Audio otimização.
* [ ] **Meta 233:** Multi-res support.
* [ ] **Meta 234:** Graphics options (AA).
* [ ] **Meta 235:** Cloud save (Epic integration).
* [ ] **Meta 236:** Test saves robust.
* [ ] **Meta 237:** In-game tutorials.
* [ ] **Meta 238:** Onboarding new players.
* [ ] **Meta 239:** Final difficulty balance.
* [ ] **Meta 240:** Playtest arte completa.
* [ ] **Meta 241:** Advanced profiling (leaks).
* [ ] **Meta 242:** Otimizar procedural.
* [ ] **Meta 243:** Custom UI elements.
* [ ] **Meta 244:** Menu anims.
* [ ] **Meta 245:** Credits screen.
* [ ] **Meta 246:** Localization prep (strings external).
* [ ] **Meta 247:** Support outro idioma (EN/PT).
* [ ] **Meta 248:** Test diff OS (Win/Linux).
* [ ] **Meta 249:** Steam integration (achievs).
* [ ] **Meta 250:** Epic/Itch prep.
* [ ] **Meta 251:** Substituir remaining assets.
* [ ] **Meta 252:** Polish cutscenes.
* [ ] **Meta 253:** Particle systems advanced.
* [ ] **Meta 254:** SFX mixing balance.
* [ ] **Meta 255:** Music menus/credits.
* [ ] **Meta 256:** Playtest polimento.
* [ ] **Meta 257:** Feedback 15+ testers.
* [ ] **Meta 258:** Iterar final bugs.
* [ ] **Meta 259:** Golden master build.
* [ ] **Meta 260:** Test multi-devices.
* [ ] **Meta 261:** Document arte pipeline.
* [ ] **Meta 262:** Naming conventions.
* [ ] **Meta 263:** Projeto backup full.
* [ ] **Meta 264:** End-to-end performance review.
* [ ] **Meta 265:** Add mod support avançado.
* [ ] **Meta 266:** Test community mods.
* [ ] **Meta 267:** Final accessibility.
* [ ] **Meta 268:** UI/UX audit externo.
* [ ] **Meta 269:** Polish narrative texts.
* [ ] **Meta 270:** Envs atos 4-6 polish.
* [ ] **Meta 271:** VFX end-game.
* [ ] **Meta 272:** SFX boss fights.
* [ ] **Meta 273:** Music boss themes.
* [ ] **Meta 274:** Playtest end-game polish.
* [ ] **Meta 275:** Iterar based testers.
* [ ] **Meta 276:** Otimizar co-op if impl.
* [ ] **Meta 277:** Final balance all modes.
* [ ] **Meta 278:** Tutorials polish.
* [ ] **Meta 279:** Onboarding test newbies.
* [ ] **Meta 280:** Milestone: Polimento: Pronto launch.
* [ ] **Meta 281:** Adicionar polish particles extras.
* [ ] **Meta 282:** SFX variations random.
* [ ] **Meta 283:** Music layering dynamic.
* [ ] **Meta 284:** Visual effects post-process fine-tune.
* [ ] **Meta 285:** Playtest visual/audio cohesion.
* [ ] **Meta 286:** Iterar immersion feedback.
* [ ] **Meta 287:** Final voice mixing.
* [ ] **Meta 288:** Accessibility audit.
* [ ] **Meta 289:** UI responsiveness mobile-like.
* [ ] **Meta 290:** Graphics presets (low/high).
* [ ] **Meta 291:** Test high-end hardware.
* [ ] **Meta 292:** Bug fix edge cases.
* [ ] **Meta 293:** Auto-save frequency adjust.
* [ ] **Meta 294:** Cloud save test real.
* [ ] **Meta 295:** Localization full test.
* [ ] **Meta 296:** Steam achievs impl.
* [ ] **Meta 297:** Store pages draft.
* [ ] **Meta 298:** Polish credits music.
* [ ] **Meta 299:** Final build candidate.
* [ ] **Meta 300:** Comprehensive QA round.

---

## Fase 4: Testes, Lançamento e Pós-Lançamento (Metas 301-400)
*A fase final, focada em preparar o jogo para o mercado, executar o lançamento e garantir a sustentabilidade a longo prazo através de atualizações e engajamento com a comunidade, seguindo o modelo de sucesso de Path of Exile.*

### 4.1 - Testes Finais e Marketing (Metas 301-320)
* [ ] **Meta 301:** Planejar alpha externo (20 testers).
* [ ] **Meta 302:** Build alpha; distribute.
* [ ] **Meta 303:** Collect alpha feedback surveys.
* [ ] **Meta 304:** Iterar alpha changes.
* [ ] **Meta 305:** Beta test (100+ via Discord).
* [ ] **Meta 306:** Build beta; metrics tracking.
* [ ] **Meta 307:** Analyze beta data (drop-off).
* [ ] **Meta 308:** Fix critical issues.
* [ ] **Meta 309:** Final balance data-based.
* [ ] **Meta 310:** Marathon playtests (10h runs).
* [ ] **Meta 311:** Trailer create (UE Sequencer).
* [ ] **Meta 312:** Screenshots/art promos.
* [ ] **Meta 313:** Game description stores.
* [ ] **Meta 314:** Steam page setup.
* [ ] **Meta 315:** Epic/Itch pages.
* [ ] **Meta 316:** Marketing social (X/Reddit posts early).
* [ ] **Meta 317:** Press kit create.
* [ ] **Meta 318:** Announce launch date.
* [ ] **Meta 319:** Final QA.
* [ ] **Meta 320:** Upload stores.

### 4.2 - Lançamento e Suporte Inicial (Metas 321-350)
* [ ] **Meta 321:** Launch day 0: Monitor crashes.
* [ ] **Meta 322:** Hotfix 24h if needed.
* [ ] **Meta 323:** Collect initial reviews.
* [ ] **Meta 324:** Analyze metrics (playtime).
* [ ] **Meta 325:** Quick post-launch iter.
* [ ] **Meta 326:** Add requested features (new skill).
* [ ] **Meta 327:** Test updates.
* [ ] **Meta 328:** Plan patch 1.1.
* [ ] **Meta 329:** Impl patch.
* [ ] **Meta 330:** Community engage (Discord/forums).
* [ ] **Meta 331:** Analytics integrate (Google).
* [ ] **Meta 332:** Otimizar data-based.
* [ ] **Meta 333:** Free update content.
* [ ] **Meta 334:** Plan DLC 1.
* [ ] **Meta 335:** Develop DLC.
* [ ] **Meta 336:** Launch DLC.
* [ ] **Meta 337:** Long-term support plan.
* [ ] **Meta 338:** Archive project.
* [ ] **Meta 339:** Celebrate launch!
* [ ] **Meta 340:** Post-mortem review.
* [ ] **Meta 341:** Monthly hotfixes.
* [ ] **Meta 342:** Seasonal events add.
* [ ] **Meta 343:** Community challenges.
* [ ] **Meta 344:** Expand multiplayer online if demand.
* [ ] **Meta 345:** Port consoles (Switch/PS).
* [ ] **Meta 346:** Marketing ongoing (streams).
* [ ] **Meta 347:** Sales/retention analysis.
* [ ] **Meta 348:** Plan sequel/expansion.
* [ ] **Meta 349:** Community mod contests.
* [ ] **Meta 350:** Update mod tools.

### 4.3 - Sustentabilidade e Futuro (Metas 351-400)
* [ ] **Meta 351:** Balance patches based forums.
* [ ] **Meta 352:** New factions DLC.
* [ ] **Meta 353:** Test DLC beta.
* [ ] **Meta 354:** Launch patch 1.2.
* [ ] **Meta 355:** Player surveys post-update.
* [ ] **Meta 356:** Iterar retention features.
* [ ] **Meta 357:** Add achievements extras.
* [ ] **Meta 358:** Steam workshop integration.
* [ ] **Meta 359:** Cross-platform prep.
* [ ] **Meta 360:** Mobile port feasibility.
* [ ] **Meta 361:** Community AMAs.
* [ ] **Meta 362:** Dev blogs updates.
* [ ] **Meta 363:** Merch ideas.
* [ ] **Meta 364:** Collaborations indie.
* [ ] **Meta 365:** Awards submissions.
* [ ] **Meta 366:** GDC postmortem talk prep.
* [ ] **Meta 367:** Expand lore books.
* [ ] **Meta 368:** New endings DLC.
* [ ] **Meta 369:** Balance meta shifts.
* [ ] **Meta 370:** Player economy monitoring.
* [ ] **Meta 371:** Anti-cheat if needed.
* [ ] **Meta 372:** Server support online.
* [ ] **Meta 373:** Test scalability.
* [ ] **Meta 374:** Free weekend events.
* [ ] **Meta 375:** Discount campaigns.
* [ ] **Meta 376:** User-generated content support.
* [ ] **Meta 377:** Annual updates plan.
* [ ] **Meta 378:** Retirement project if success.
* [ ] **Meta 379:** Lessons learned doc.
* [ ] **Meta 380:** Share indie community.
* [ ] **Meta 381:** Monitor bugs long-term.
* [ ] **Meta 382:** Community mods highlight.
* [ ] **Meta 383:** Sequel brainstorming.
* [ ] **Meta 384:** Fan art contests.
* [ ] **Meta 385:** Lore expansions free.
* [ ] **Meta 386:** Balance polls.
* [ ] **Meta 387:** New skills community-voted.
* [ ] **Meta 388:** Test servers impl.
* [ ] **Meta 389:** Crossovers ideas.
* [ ] **Meta 390:** Sustainability financial plan.
* [ ] **Meta 391:** Team expansion if growth.
* [ ] **Meta 392:** Mentorship indie devs.
* [ ] **Meta 393:** GDC presentations.
* [ ] **Meta 394:** Archive old builds.
* [ ] **Meta 395:** Remaster ideas.
* [ ] **Meta 396:** VR mode feasibility.
* [ ] **Meta 397:** Final major update.
* [ ] **Meta 398:** Farewell community event.
* [ ] **Meta 399:** Project closure.
* [ ] **Meta 400:** Reflect on journey; start next project.

## Hábitos de Desenvolvimento
* **Versionamento:** Commits diários, com branches por feature.
* **Design:** Abordagem data-driven para tudo que for possível.
* **Qualidade:** Playtests semanais para feedback rápido.
* **Organização:** Manter o backlog atualizado no GitHub Issues.
* **Bem-estar:** Dedicar tempo para prevenção de burnout e pausas planejadas.
* **Boas Práticas (UE):** Ativar plugins essenciais cedo (ex: Enhanced Input) e testar em múltiplos hardwares desde o início.
