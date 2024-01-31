using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using kh2ServerApi.Infrastructure.Reverse.Models;

namespace kh2ServerApi.Infrastructure.Reverse;

public partial class KH2emsServerContext : DbContext
{
    protected readonly IConfiguration _configuration;

    public KH2emsServerContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public virtual DbSet<AiIndex> AiIndices { get; set; }

    public virtual DbSet<AlarmPriority> AlarmPriorities { get; set; }

    public virtual DbSet<AlarmType> AlarmTypes { get; set; }

    public virtual DbSet<AoIndex> AoIndices { get; set; }

    public virtual DbSet<BaseVoltage> BaseVoltages { get; set; }

    public virtual DbSet<BiIndex> BiIndices { get; set; }

    public virtual DbSet<BoIndex> BoIndices { get; set; }

    public virtual DbSet<BoIndexToRemote> BoIndexToRemotes { get; set; }

    public virtual DbSet<BusAuthInfo> BusAuthInfos { get; set; }

    public virtual DbSet<BusOperationState> BusOperationStates { get; set; }

    public virtual DbSet<BusRouteInfo> BusRouteInfos { get; set; }

    public virtual DbSet<BusRouteNumber> BusRouteNumbers { get; set; }

    public virtual DbSet<BusRouteStopInfo> BusRouteStopInfos { get; set; }

    public virtual DbSet<BusStopInfo> BusStopInfos { get; set; }

    public virtual DbSet<BusStopLocation> BusStopLocations { get; set; }

    public virtual DbSet<BusStopPositionInfo> BusStopPositionInfos { get; set; }

    public virtual DbSet<BusTagoCityCode> BusTagoCityCodes { get; set; }

    public virtual DbSet<BusTagoLocationInfo> BusTagoLocationInfos { get; set; }

    public virtual DbSet<BusTagoRouteInfo> BusTagoRouteInfos { get; set; }

    public virtual DbSet<BusTagoStopInfo> BusTagoStopInfos { get; set; }

    public virtual DbSet<BusTagoVehicle> BusTagoVehicles { get; set; }

    public virtual DbSet<CalculationDefineCode> CalculationDefineCodes { get; set; }

    public virtual DbSet<CalculationIndex> CalculationIndices { get; set; }

    public virtual DbSet<CeqCalculationDefine> CeqCalculationDefines { get; set; }

    public virtual DbSet<CeqProperty> CeqProperties { get; set; }

    public virtual DbSet<CeqType> CeqTypes { get; set; }

    public virtual DbSet<CeqTypeGroup> CeqTypeGroups { get; set; }

    public virtual DbSet<CeqValue> CeqValues { get; set; }

    public virtual DbSet<CommType> CommTypes { get; set; }

    public virtual DbSet<CommonIndex> CommonIndices { get; set; }

    public virtual DbSet<CommonIndexGroup> CommonIndexGroups { get; set; }

    public virtual DbSet<CompanyCode> CompanyCodes { get; set; }

    public virtual DbSet<ComputerGroup> ComputerGroups { get; set; }

    public virtual DbSet<ComputerInfo> ComputerInfos { get; set; }

    public virtual DbSet<ComputerState> ComputerStates { get; set; }

    public virtual DbSet<ConductingEquipment> ConductingEquipments { get; set; }

    public virtual DbSet<CounterIndex> CounterIndices { get; set; }

    public virtual DbSet<DataType> DataTypes { get; set; }

    public virtual DbSet<DerType> DerTypes { get; set; }

    public virtual DbSet<DeviceCommConfig> DeviceCommConfigs { get; set; }

    public virtual DbSet<DeviceCommUnit> DeviceCommUnits { get; set; }

    public virtual DbSet<DevicePointScenario> DevicePointScenarios { get; set; }

    public virtual DbSet<DeviceScenarioType> DeviceScenarioTypes { get; set; }

    public virtual DbSet<DvrSystem> DvrSystems { get; set; }

    public virtual DbSet<GroupOffice> GroupOffices { get; set; }

    public virtual DbSet<IdentityObject> IdentityObjects { get; set; }

    public virtual DbSet<LogBusOperation> LogBusOperations { get; set; }

    public virtual DbSet<LogComputer> LogComputers { get; set; }

    public virtual DbSet<LogControl> LogControls { get; set; }

    public virtual DbSet<LogDeviceComm> LogDeviceComms { get; set; }

    public virtual DbSet<LogEvent> LogEvents { get; set; }

    public virtual DbSet<LogProgram> LogPrograms { get; set; }

    public virtual DbSet<LogSnmp> LogSnmps { get; set; }

    public virtual DbSet<LogSystem> LogSystems { get; set; }

    public virtual DbSet<MasterIndex> MasterIndices { get; set; }

    public virtual DbSet<MemberOffice> MemberOffices { get; set; }

    public virtual DbSet<ModbusSchedule> ModbusSchedules { get; set; }

    public virtual DbSet<ModelIndex> ModelIndices { get; set; }

    public virtual DbSet<ModelInfo> ModelInfos { get; set; }

    public virtual DbSet<ModelItemIndex> ModelItemIndices { get; set; }

    public virtual DbSet<MsgErrorType> MsgErrorTypes { get; set; }

    public virtual DbSet<MsgGroup> MsgGroups { get; set; }

    public virtual DbSet<MsgType> MsgTypes { get; set; }

    public virtual DbSet<ObjectType> ObjectTypes { get; set; }

    public virtual DbSet<PointQualityCode> PointQualityCodes { get; set; }

    public virtual DbSet<PointTagCode> PointTagCodes { get; set; }

    public virtual DbSet<PointType> PointTypes { get; set; }

    public virtual DbSet<PosAlarmCode> PosAlarmCodes { get; set; }

    public virtual DbSet<PosBsnsCode> PosBsnsCodes { get; set; }

    public virtual DbSet<PosEquipmentLink> PosEquipmentLinks { get; set; }

    public virtual DbSet<PosSystem> PosSystems { get; set; }

    public virtual DbSet<ProgramInfo> ProgramInfos { get; set; }

    public virtual DbSet<ProgramState> ProgramStates { get; set; }

    public virtual DbSet<ProgramType> ProgramTypes { get; set; }

    public virtual DbSet<ProtocolType> ProtocolTypes { get; set; }

    public virtual DbSet<RemoteControlValue> RemoteControlValues { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportForm> ReportForms { get; set; }

    public virtual DbSet<ReportFormType> ReportFormTypes { get; set; }

    public virtual DbSet<ReportOperatorType> ReportOperatorTypes { get; set; }

    public virtual DbSet<ScaleFactor> ScaleFactors { get; set; }

    public virtual DbSet<SnmpGroup> SnmpGroups { get; set; }

    public virtual DbSet<SnmpInfo> SnmpInfos { get; set; }

    public virtual DbSet<SnmpOidInfo> SnmpOidInfos { get; set; }

    public virtual DbSet<SnmpOsType> SnmpOsTypes { get; set; }

    public virtual DbSet<SnmpState> SnmpStates { get; set; }

    public virtual DbSet<Sound> Sounds { get; set; }

    public virtual DbSet<StateGroup> StateGroups { get; set; }

    public virtual DbSet<StateValue> StateValues { get; set; }

    public virtual DbSet<StationType> StationTypes { get; set; }

    public virtual DbSet<Substation> Substations { get; set; }

    public virtual DbSet<SystemSetting> SystemSettings { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAuthorityType> UserAuthorityTypes { get; set; }

    public virtual DbSet<VBusDetailInfoView> VBusDetailInfoViews { get; set; }

    public virtual DbSet<VBusRouteStopView> VBusRouteStopViews { get; set; }

    public virtual DbSet<VBusTagoDetailInfoView> VBusTagoDetailInfoViews { get; set; }

    public virtual DbSet<VCeqPointIndexView> VCeqPointIndexViews { get; set; }

    public virtual DbSet<VComputerInfoView> VComputerInfoViews { get; set; }

    public virtual DbSet<VConductingEquipmentView> VConductingEquipmentViews { get; set; }

    public virtual DbSet<VDevicePointIndexView> VDevicePointIndexViews { get; set; }

    public virtual DbSet<VPointIndexView> VPointIndexViews { get; set; }

    public virtual DbSet<VProgramInfoView> VProgramInfoViews { get; set; }

    public virtual DbSet<VRealMessageListView> VRealMessageListViews { get; set; }

    public virtual DbSet<VRealPointListView> VRealPointListViews { get; set; }

    public virtual DbSet<VSnmpInfoView> VSnmpInfoViews { get; set; }

    public virtual DbSet<VStationView> VStationViews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.1.142,3306;database=k_h2ems_server;user=root;password=choshin01", Microsoft.EntityFrameworkCore.ServerVersion.Parse("11.1.2-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<AiIndex>(entity =>
        {
            entity.HasKey(e => e.IndexId).HasName("PRIMARY");

            entity.ToTable("ai_index", tb => tb.HasComment("아날로그 계측 표준 인덱스"));

            entity.HasIndex(e => e.AlarmPriorityFk, "FK_ai_index_alarm_priority_fk");

            entity.HasIndex(e => e.DataTypeFk, "FK_ai_index_data_type_fk");

            entity.HasIndex(e => e.ScaleFactorFk, "FK_ai_index_scale_factor_fk");

            entity.HasIndex(e => e.StateGroupFk, "FK_ai_index_state_group_fk");

            entity.HasIndex(e => e.UnitFk, "FK_ai_index_unit_fk");

            entity.HasIndex(e => e.EName, "UC_ai_index").IsUnique();

            entity.Property(e => e.IndexId)
                .ValueGeneratedNever()
                .HasComment("아날로그 계측 인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("index_id");
            entity.Property(e => e.AlarmPriorityFk)
                .HasComment("알람 우선순위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_fk");
            entity.Property(e => e.AlarmTypeFk)
                .HasDefaultValueSql("'0'")
                .HasComment("alarm_type_fk")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_type_fk");
            entity.Property(e => e.DataTypeFk)
                .HasComment("데이터 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("data_type_fk");
            entity.Property(e => e.Deadband)
                .HasComment("deadband 값")
                .HasColumnName("deadband");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("아날로그 계측 영문 인덱스명")
                .HasColumnName("e_name");
            entity.Property(e => e.LimitMaxValue)
                .HasComment("최대 LIMIT 값")
                .HasColumnName("limit_max_value");
            entity.Property(e => e.LimitMinValue)
                .HasComment("최소 LIMIT 값")
                .HasColumnName("limit_min_value");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("아날로그 계측 인덱스명")
                .HasColumnName("name");
            entity.Property(e => e.ScaleFactorFk)
                .HasComment("스케일 펙터 ID")
                .HasColumnType("int(11)")
                .HasColumnName("scale_factor_fk");
            entity.Property(e => e.StateGroupFk)
                .HasComment("상태 구룹 ID")
                .HasColumnType("int(11)")
                .HasColumnName("state_group_fk");
            entity.Property(e => e.UnitFk)
                .HasComment("단위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("unit_fk");

            entity.HasOne(d => d.AlarmPriorityFkNavigation).WithMany(p => p.AiIndices)
                .HasForeignKey(d => d.AlarmPriorityFk)
                .HasConstraintName("FK_ai_index_alarm_priority_fk");

            entity.HasOne(d => d.DataTypeFkNavigation).WithMany(p => p.AiIndices)
                .HasForeignKey(d => d.DataTypeFk)
                .HasConstraintName("FK_ai_index_data_type_fk");

            entity.HasOne(d => d.ScaleFactorFkNavigation).WithMany(p => p.AiIndices)
                .HasForeignKey(d => d.ScaleFactorFk)
                .HasConstraintName("FK_ai_index_scale_factor_fk");

            entity.HasOne(d => d.StateGroupFkNavigation).WithMany(p => p.AiIndices)
                .HasForeignKey(d => d.StateGroupFk)
                .HasConstraintName("FK_ai_index_state_group_fk");

            entity.HasOne(d => d.UnitFkNavigation).WithMany(p => p.AiIndices)
                .HasForeignKey(d => d.UnitFk)
                .HasConstraintName("FK_ai_index_unit_fk");
        });

        modelBuilder.Entity<AlarmPriority>(entity =>
        {
            entity.HasKey(e => e.AlarmPriorityId).HasName("PRIMARY");

            entity.ToTable("alarm_priority", tb => tb.HasComment("알람 우선순위"));

            entity.Property(e => e.AlarmPriorityId)
                .ValueGeneratedNever()
                .HasComment("알람 우선순위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("알람 우선순위명")
                .HasColumnName("name");
            entity.Property(e => e.SoundFk)
                .HasComment("소리 ID")
                .HasColumnType("int(11)")
                .HasColumnName("sound_fk");
        });

        modelBuilder.Entity<AlarmType>(entity =>
        {
            entity.HasKey(e => e.AlarmTypeId).HasName("PRIMARY");

            entity.ToTable("alarm_type", tb => tb.HasComment("알람 타입"));

            entity.Property(e => e.AlarmTypeId)
                .ValueGeneratedNever()
                .HasComment("알람 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_type_id");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("알람 영문명")
                .HasColumnName("e_name");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("알람 타입명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<AoIndex>(entity =>
        {
            entity.HasKey(e => e.IndexId).HasName("PRIMARY");

            entity.ToTable("ao_index", tb => tb.HasComment("아날로그 설정 표준 인덱스"));

            entity.HasIndex(e => e.AlarmPriorityFk, "FK_ao_index_alarm_priority_fk");

            entity.HasIndex(e => e.DataTypeFk, "FK_ao_index_data_type_fk");

            entity.HasIndex(e => e.ScaleFactorFk, "FK_ao_index_scale_factor_fk");

            entity.HasIndex(e => e.StateGroupFk, "FK_ao_index_state_group_fk");

            entity.HasIndex(e => e.UnitFk, "FK_ao_index_unit_fk");

            entity.HasIndex(e => e.EName, "UC_ao_index").IsUnique();

            entity.Property(e => e.IndexId)
                .ValueGeneratedNever()
                .HasComment("아날로그 설정 인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("index_id");
            entity.Property(e => e.AlarmPriorityFk)
                .HasComment("알람 우선순위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_fk");
            entity.Property(e => e.AlarmTypeFk)
                .HasDefaultValueSql("'0'")
                .HasComment("alarm_type_fk")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_type_fk");
            entity.Property(e => e.DataTypeFk)
                .HasComment("데이터 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("data_type_fk");
            entity.Property(e => e.Deadband)
                .HasComment("deadband 값")
                .HasColumnName("deadband");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("아날로그 설정 영문 인덱스명")
                .HasColumnName("e_name");
            entity.Property(e => e.LimitMaxValue)
                .HasComment("최대 LIMIT 값")
                .HasColumnName("limit_max_value");
            entity.Property(e => e.LimitMinValue)
                .HasComment("최소 LIMIT 값")
                .HasColumnName("limit_min_value");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("아날로그 설정 인덱스명")
                .HasColumnName("name");
            entity.Property(e => e.ScaleFactorFk)
                .HasComment("스케일 펙터터 ID")
                .HasColumnType("int(11)")
                .HasColumnName("scale_factor_fk");
            entity.Property(e => e.StateGroupFk)
                .HasComment("상태 그룹 ID")
                .HasColumnType("int(11)")
                .HasColumnName("state_group_fk");
            entity.Property(e => e.UnitFk)
                .HasComment("단위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("unit_fk");

            entity.HasOne(d => d.AlarmPriorityFkNavigation).WithMany(p => p.AoIndices)
                .HasForeignKey(d => d.AlarmPriorityFk)
                .HasConstraintName("FK_ao_index_alarm_priority_fk");

            entity.HasOne(d => d.DataTypeFkNavigation).WithMany(p => p.AoIndices)
                .HasForeignKey(d => d.DataTypeFk)
                .HasConstraintName("FK_ao_index_data_type_fk");

            entity.HasOne(d => d.ScaleFactorFkNavigation).WithMany(p => p.AoIndices)
                .HasForeignKey(d => d.ScaleFactorFk)
                .HasConstraintName("FK_ao_index_scale_factor_fk");

            entity.HasOne(d => d.StateGroupFkNavigation).WithMany(p => p.AoIndices)
                .HasForeignKey(d => d.StateGroupFk)
                .HasConstraintName("FK_ao_index_state_group_fk");

            entity.HasOne(d => d.UnitFkNavigation).WithMany(p => p.AoIndices)
                .HasForeignKey(d => d.UnitFk)
                .HasConstraintName("FK_ao_index_unit_fk");
        });

        modelBuilder.Entity<BaseVoltage>(entity =>
        {
            entity.HasKey(e => e.BaseVoltageId).HasName("PRIMARY");

            entity.ToTable("base_voltage", tb => tb.HasComment("기준 전압"));

            entity.Property(e => e.BaseVoltageId)
                .ValueGeneratedNever()
                .HasComment("기준 전압 ID")
                .HasColumnType("int(11)")
                .HasColumnName("base_voltage_id");
            entity.Property(e => e.MaxVoltage)
                .HasComment("최대 전압")
                .HasColumnName("max_voltage");
            entity.Property(e => e.MaxVoltageUnitFk)
                .HasComment("최대 전압 단위")
                .HasColumnType("int(11)")
                .HasColumnName("max_voltage_unit_fk");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("기준 전압명")
                .HasColumnName("name");
            entity.Property(e => e.NormalVoltage)
                .HasComment("기준 전압")
                .HasColumnName("normal_voltage");
            entity.Property(e => e.NormalVoltageUnitFk)
                .HasComment("기준 전압 단위")
                .HasColumnType("int(11)")
                .HasColumnName("normal_voltage_unit_fk");
        });

        modelBuilder.Entity<BiIndex>(entity =>
        {
            entity.HasKey(e => e.IndexId).HasName("PRIMARY");

            entity.ToTable("bi_index", tb => tb.HasComment("상태 계측 표준 인덱스"));

            entity.HasIndex(e => e.AlarmPriorityFk, "FK_bi_index_alarm_priority_fk");

            entity.HasIndex(e => e.DataTypeFk, "FK_bi_index_data_type_fk");

            entity.HasIndex(e => e.StateGroupFk, "FK_bi_index_state_group_fk");

            entity.HasIndex(e => e.EName, "UC_bi_index").IsUnique();

            entity.Property(e => e.IndexId)
                .ValueGeneratedNever()
                .HasComment("상태 계측 인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("index_id");
            entity.Property(e => e.AlarmPriorityFk)
                .HasComment("알람 우선순위 코드")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_fk");
            entity.Property(e => e.AlarmTypeFk)
                .HasDefaultValueSql("'0'")
                .HasComment("alarm_type_fk")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_type_fk");
            entity.Property(e => e.DataTypeFk)
                .HasComment("데이터 타입 코드")
                .HasColumnType("int(11)")
                .HasColumnName("data_type_fk");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("상태 계측 영문 인덱스명")
                .HasColumnName("e_name");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("상태 계측 인덱스명")
                .HasColumnName("name");
            entity.Property(e => e.StateGroupFk)
                .HasComment("상태 그룹 코드")
                .HasColumnType("int(11)")
                .HasColumnName("state_group_fk");

            entity.HasOne(d => d.AlarmPriorityFkNavigation).WithMany(p => p.BiIndices)
                .HasForeignKey(d => d.AlarmPriorityFk)
                .HasConstraintName("FK_bi_index_alarm_priority_fk");

            entity.HasOne(d => d.DataTypeFkNavigation).WithMany(p => p.BiIndices)
                .HasForeignKey(d => d.DataTypeFk)
                .HasConstraintName("FK_bi_index_data_type_fk");

            entity.HasOne(d => d.StateGroupFkNavigation).WithMany(p => p.BiIndices)
                .HasForeignKey(d => d.StateGroupFk)
                .HasConstraintName("FK_bi_index_state_group_fk");
        });

        modelBuilder.Entity<BoIndex>(entity =>
        {
            entity.HasKey(e => e.IndexId).HasName("PRIMARY");

            entity.ToTable("bo_index", tb => tb.HasComment("상태 제어 표준 인덱스"));

            entity.HasIndex(e => e.LinkBiIndexFk, "FK_bo_index_link_bi_index_fk");

            entity.HasIndex(e => e.EName, "UC_bo_index").IsUnique();

            entity.Property(e => e.IndexId)
                .ValueGeneratedNever()
                .HasComment("제어 인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("index_id");
            entity.Property(e => e.AlarmTypeFk)
                .HasDefaultValueSql("'0'")
                .HasComment("alarm_type_fk")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_type_fk");
            entity.Property(e => e.ControlCount)
                .HasComment("상태 제어 코드 개수")
                .HasColumnType("int(11)")
                .HasColumnName("control_count");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("제어 영문 인덱스명")
                .HasColumnName("e_name");
            entity.Property(e => e.LinkBiIndexFk)
                .HasComment("연결된 BI 인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("link_bi_index_fk");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("제어 인덱스명")
                .HasColumnName("name");

            entity.HasOne(d => d.LinkBiIndexFkNavigation).WithMany(p => p.BoIndices)
                .HasForeignKey(d => d.LinkBiIndexFk)
                .HasConstraintName("FK_bo_index_link_bi_index_fk");
        });

        modelBuilder.Entity<BoIndexToRemote>(entity =>
        {
            entity.HasKey(e => e.BoIndexRemoteId).HasName("PRIMARY");

            entity.ToTable("bo_index_to_remote", tb => tb.HasComment("상태 제어 코드 설정"));

            entity.HasIndex(e => e.BoIndexFk, "FK_bo_index_to_remote_bo_index_fk");

            entity.HasIndex(e => e.RemoteControlIndexFk, "FK_bo_index_to_remote_remote_control_index_fk");

            entity.Property(e => e.BoIndexRemoteId)
                .ValueGeneratedNever()
                .HasComment("제어 코드 ID")
                .HasColumnType("int(11)")
                .HasColumnName("bo_index_remote_id");
            entity.Property(e => e.BoIndexFk)
                .HasComment("연결된 BO 인덱스")
                .HasColumnType("int(11)")
                .HasColumnName("bo_index_fk");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("제어 코드명")
                .HasColumnName("name");
            entity.Property(e => e.RemoteControlIndexFk)
                .HasComment("연결된 원격 제어 설정 ID")
                .HasColumnType("int(11)")
                .HasColumnName("remote_control_index_fk");
            entity.Property(e => e.ValidBiValue)
                .HasComment("제어 유효성 검사값")
                .HasColumnType("int(11)")
                .HasColumnName("valid_bi_value");

            entity.HasOne(d => d.BoIndexFkNavigation).WithMany(p => p.BoIndexToRemotes)
                .HasForeignKey(d => d.BoIndexFk)
                .HasConstraintName("FK_bo_index_to_remote_bo_index_fk");

            entity.HasOne(d => d.RemoteControlIndexFkNavigation).WithMany(p => p.BoIndexToRemotes)
                .HasForeignKey(d => d.RemoteControlIndexFk)
                .HasConstraintName("FK_bo_index_to_remote_remote_control_index_fk");
        });

        modelBuilder.Entity<BusAuthInfo>(entity =>
        {
            entity.HasKey(e => e.AuthId).HasName("PRIMARY");

            entity.ToTable("bus_auth_info", tb => tb.HasComment("버스 API 인증키"));

            entity.Property(e => e.AuthId)
                .ValueGeneratedNever()
                .HasComment("인증ID")
                .HasColumnType("int(11)")
                .HasColumnName("auth_id");
            entity.Property(e => e.AuthKey)
                .HasMaxLength(256)
                .HasComment("인증키")
                .HasColumnName("auth_key");
            entity.Property(e => e.KakaoKey)
                .HasMaxLength(256)
                .HasComment("kakao_key")
                .HasColumnName("kakao_key");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("이름")
                .HasColumnName("name");
        });

        modelBuilder.Entity<BusOperationState>(entity =>
        {
            entity.HasKey(e => e.VehicleNo).HasName("PRIMARY");

            entity.ToTable("bus_operation_state", tb => tb.HasComment("버스타고 차량운영상태"));

            entity.Property(e => e.VehicleNo)
                .ValueGeneratedNever()
                .HasComment("차량번호")
                .HasColumnType("int(11)")
                .HasColumnName("vehicle_no");
            entity.Property(e => e.AfterFuelAmount)
                .HasComment("연료충전완료후량")
                .HasColumnType("int(11)")
                .HasColumnName("after_fuel_amount");
            entity.Property(e => e.BusRunStop)
                .HasComment("사용여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("bus_run_stop");
            entity.Property(e => e.CityCode)
                .HasComment("도시코드")
                .HasColumnType("int(11)")
                .HasColumnName("city_code");
            entity.Property(e => e.DeviceUpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("device_update_time");
            entity.Property(e => e.FuelInjectionDate)
                .HasComment("연료주입일")
                .HasColumnType("timestamp")
                .HasColumnName("fuel_injection_date");
            entity.Property(e => e.FuelInjectionMileage)
                .HasComment("연료주입시총주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("fuel_injection_mileage");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.RouteId)
                .HasMaxLength(16)
                .HasComment("노선ID")
                .HasColumnName("route_id");
            entity.Property(e => e.TotalMileage)
                .HasComment("전체주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("total_mileage");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<BusRouteInfo>(entity =>
        {
            entity.HasKey(e => e.BrtStdId).HasName("PRIMARY");

            entity.ToTable("bus_route_info", tb => tb.HasComment("버스노선정보"));

            entity.Property(e => e.BrtStdId)
                .ValueGeneratedNever()
                .HasComment("노선 식별 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("brt_std_id");
            entity.Property(e => e.BrtBusNum)
                .HasComment("버스대수")
                .HasColumnType("int(11)")
                .HasColumnName("brt_bus_num");
            entity.Property(e => e.BrtClass)
                .HasComment("노선번호확장")
                .HasColumnType("tinyint(4)")
                .HasColumnName("brt_class");
            entity.Property(e => e.BrtDirection)
                .HasComment("노선방향(1:정방향, 2:역방향)")
                .HasColumnType("tinyint(4)")
                .HasColumnName("brt_direction");
            entity.Property(e => e.BrtEndName)
                .HasMaxLength(64)
                .HasComment("종점명")
                .HasColumnName("brt_end_name");
            entity.Property(e => e.BrtFirstTime)
                .HasMaxLength(8)
                .HasComment("첫차시각")
                .HasColumnName("brt_first_time");
            entity.Property(e => e.BrtId)
                .HasComment("노선번호")
                .HasColumnType("int(11)")
                .HasColumnName("brt_id");
            entity.Property(e => e.BrtIlregInterval)
                .HasMaxLength(8)
                .HasComment("배차간격불규칙여부")
                .HasColumnName("brt_ilreg_interval");
            entity.Property(e => e.BrtLastTime)
                .HasMaxLength(8)
                .HasComment("막차시각")
                .HasColumnName("brt_last_time");
            entity.Property(e => e.BrtLength)
                .HasComment("노선길이")
                .HasColumnType("int(11)")
                .HasColumnName("brt_length");
            entity.Property(e => e.BrtMaxInterval)
                .HasComment("비첨두시배차간격")
                .HasColumnType("int(11)")
                .HasColumnName("brt_max_interval");
            entity.Property(e => e.BrtMinInterval)
                .HasComment("점두시배차간격")
                .HasColumnType("int(11)")
                .HasColumnName("brt_min_interval");
            entity.Property(e => e.BrtNeedTime)
                .HasComment("평균소요시간")
                .HasColumnType("int(11)")
                .HasColumnName("brt_need_time");
            entity.Property(e => e.BrtStartName)
                .HasMaxLength(64)
                .HasComment("기점명")
                .HasColumnName("brt_start_name");
            entity.Property(e => e.BrtSubId)
                .HasMaxLength(8)
                .HasComment("분선ID")
                .HasColumnName("brt_sub_id");
            entity.Property(e => e.BrtUseYn)
                .HasComment("사용여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("brt_use_yn");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("노선이름")
                .HasColumnName("name");
        });

        modelBuilder.Entity<BusRouteNumber>(entity =>
        {
            entity.HasKey(e => new { e.BrtId, e.BrtClass })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("bus_route_number", tb => tb.HasComment("버스노선번호"));

            entity.Property(e => e.BrtId)
                .HasComment("노선번호")
                .HasColumnType("int(11)")
                .HasColumnName("brt_id");
            entity.Property(e => e.BrtClass)
                .HasComment("노선번호확장")
                .HasColumnType("tinyint(4)")
                .HasColumnName("brt_class");
            entity.Property(e => e.BrtUseYn)
                .HasComment("사용여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("brt_use_yn");
        });

        modelBuilder.Entity<BusRouteStopInfo>(entity =>
        {
            entity.HasKey(e => new { e.BrtStdId, e.BrsSeqno })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("bus_route_stop_info", tb => tb.HasComment("노선별 정류장 정보"));

            entity.HasIndex(e => e.StopStandardId, "FK_bus_stop_info_TO_bus_route_stop_info");

            entity.Property(e => e.BrtStdId)
                .HasComment("노선 식별 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("brt_std_id");
            entity.Property(e => e.BrsSeqno)
                .HasComment("정류장순번")
                .HasColumnType("int(11)")
                .HasColumnName("brs_seqno");
            entity.Property(e => e.Remark)
                .HasMaxLength(64)
                .HasComment("비고")
                .HasColumnName("remark");
            entity.Property(e => e.StopStandardId)
                .HasComment("정류장 표준ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("stop_standard_id");

            entity.HasOne(d => d.BrtStd).WithMany(p => p.BusRouteStopInfos)
                .HasForeignKey(d => d.BrtStdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bus_route_info_TO_bus_route_stop_info");

            entity.HasOne(d => d.StopStandard).WithMany(p => p.BusRouteStopInfos)
                .HasForeignKey(d => d.StopStandardId)
                .HasConstraintName("FK_bus_stop_info_TO_bus_route_stop_info");
        });

        modelBuilder.Entity<BusStopInfo>(entity =>
        {
            entity.HasKey(e => e.StopStandardId).HasName("PRIMARY");

            entity.ToTable("bus_stop_info", tb => tb.HasComment("정류장 정보"));

            entity.Property(e => e.StopStandardId)
                .ValueGeneratedNever()
                .HasComment("정류장 표준ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("stop_standard_id");
            entity.Property(e => e.BnodeId)
                .HasComment("지점ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("bnode_id");
            entity.Property(e => e.BrnSeqNo)
                .HasComment("지점순번")
                .HasColumnType("int(11)")
                .HasColumnName("brn_seq_no");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("이름")
                .HasColumnName("name");
            entity.Property(e => e.StopId)
                .HasComment("정류장 ID")
                .HasColumnType("int(11)")
                .HasColumnName("stop_id");
        });

        modelBuilder.Entity<BusStopLocation>(entity =>
        {
            entity.HasKey(e => e.BusNo).HasName("PRIMARY");

            entity.ToTable("bus_stop_location", tb => tb.HasComment("버스정보"));

            entity.HasIndex(e => e.BrtStdId, "FK_bus_route_info_TO_bus_stop_location");

            entity.Property(e => e.BusNo)
                .ValueGeneratedNever()
                .HasComment("버스 번호")
                .HasColumnType("int(11)")
                .HasColumnName("bus_no");
            entity.Property(e => e.AfterFuelAmount)
                .HasComment("연료충전완료후량")
                .HasColumnType("int(11)")
                .HasColumnName("after_fuel_amount");
            entity.Property(e => e.BrtStdId)
                .HasComment("노선 식별 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("brt_std_id");
            entity.Property(e => e.BrtUseYn)
                .HasComment("사용여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("brt_use_yn");
            entity.Property(e => e.BusLow)
                .HasComment("저상여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("bus_low");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("생성시간")
                .HasColumnType("timestamp")
                .HasColumnName("create_time");
            entity.Property(e => e.FuelInjectionDate)
                .HasComment("연료주입일")
                .HasColumnType("timestamp")
                .HasColumnName("fuel_injection_date");
            entity.Property(e => e.FuelInjectionMileage)
                .HasComment("연료주입시총주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("fuel_injection_mileage");
            entity.Property(e => e.NewStopStdId)
                .HasComment("현재 정류장 위치")
                .HasColumnType("bigint(20)")
                .HasColumnName("new_stop_std_id");
            entity.Property(e => e.OldStopStdId)
                .HasComment("이전 정류장 위치")
                .HasColumnType("bigint(20)")
                .HasColumnName("old_stop_std_id");
            entity.Property(e => e.TodayMileage)
                .HasComment("일일주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("today_mileage");
            entity.Property(e => e.TotalMileage)
                .HasComment("전체주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("total_mileage");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");

            entity.HasOne(d => d.BrtStd).WithMany(p => p.BusStopLocations)
                .HasForeignKey(d => d.BrtStdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bus_route_info_TO_bus_stop_location");
        });

        modelBuilder.Entity<BusStopPositionInfo>(entity =>
        {
            entity.HasKey(e => e.StopStandardId).HasName("PRIMARY");

            entity.ToTable("bus_stop_position_info", tb => tb.HasComment("버스 정류장 위치 정보"));

            entity.Property(e => e.StopStandardId)
                .ValueGeneratedNever()
                .HasComment("정류장 표준ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("stop_standard_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("이름")
                .HasColumnName("name");
            entity.Property(e => e.StopId)
                .HasComment("정류장 ID")
                .HasColumnType("int(11)")
                .HasColumnName("stop_id");
            entity.Property(e => e.Stopx)
                .HasComment("x좌표(경도)")
                .HasColumnName("stopx");
            entity.Property(e => e.Stopy)
                .HasComment("y좌표(위도)")
                .HasColumnName("stopy");
        });

        modelBuilder.Entity<BusTagoCityCode>(entity =>
        {
            entity.HasKey(e => e.CityCode).HasName("PRIMARY");

            entity.ToTable("bus_tago_city_code", tb => tb.HasComment("버스타고도시코드"));

            entity.Property(e => e.CityCode)
                .ValueGeneratedNever()
                .HasComment("도시코드")
                .HasColumnType("int(11)")
                .HasColumnName("city_code");
            entity.Property(e => e.CityName)
                .HasMaxLength(64)
                .HasComment("도시이름")
                .HasColumnName("city_name");
            entity.Property(e => e.UseYn)
                .HasComment("사용여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("use_yn");
        });

        modelBuilder.Entity<BusTagoLocationInfo>(entity =>
        {
            entity.HasKey(e => e.VehicleNo).HasName("PRIMARY");

            entity.ToTable("bus_tago_location_info", tb => tb.HasComment("버스타고 위치정보"));

            entity.Property(e => e.VehicleNo)
                .ValueGeneratedNever()
                .HasComment("차량번호")
                .HasColumnType("int(11)")
                .HasColumnName("vehicle_no");
            entity.Property(e => e.AfterFuelAmount)
                .HasComment("연료충전완료후량")
                .HasColumnType("int(11)")
                .HasColumnName("after_fuel_amount");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("생성시간")
                .HasColumnType("timestamp")
                .HasColumnName("create_time");
            entity.Property(e => e.FuelInjectionDate)
                .HasComment("연료주입일")
                .HasColumnType("timestamp")
                .HasColumnName("fuel_injection_date");
            entity.Property(e => e.FuelInjectionMileage)
                .HasComment("연료주입시총주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("fuel_injection_mileage");
            entity.Property(e => e.GpsLati)
                .HasComment("위도")
                .HasColumnName("gps_lati");
            entity.Property(e => e.GpsLong)
                .HasComment("경도")
                .HasColumnName("gps_long");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.NodeId)
                .HasMaxLength(16)
                .HasComment("정류장ID")
                .HasColumnName("node_id");
            entity.Property(e => e.NodeName)
                .HasMaxLength(64)
                .HasComment("정류장이름")
                .HasColumnName("node_name");
            entity.Property(e => e.NodeOrder)
                .HasComment("노드순서")
                .HasColumnType("int(11)")
                .HasColumnName("node_order");
            entity.Property(e => e.RouteId)
                .HasMaxLength(16)
                .HasComment("노선ID")
                .HasColumnName("route_id");
            entity.Property(e => e.RouteTp)
                .HasMaxLength(16)
                .HasComment("노선유형")
                .HasColumnName("route_tp");
            entity.Property(e => e.TodayMileage)
                .HasComment("일일주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("today_mileage");
            entity.Property(e => e.TotalMileage)
                .HasComment("전체주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("total_mileage");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<BusTagoRouteInfo>(entity =>
        {
            entity.HasKey(e => e.RouteId).HasName("PRIMARY");

            entity.ToTable("bus_tago_route_info", tb => tb.HasComment("버스타고 노선정보"));

            entity.HasIndex(e => e.CityCode, "FK_bus_tago_city_code_TO_bus_tago_route_info");

            entity.Property(e => e.RouteId)
                .HasMaxLength(16)
                .HasComment("노선ID")
                .HasColumnName("route_id");
            entity.Property(e => e.CityCode)
                .HasComment("도시코드")
                .HasColumnType("int(11)")
                .HasColumnName("city_code");
            entity.Property(e => e.EndNodeName)
                .HasMaxLength(32)
                .HasComment("종점")
                .HasColumnName("end_node_name");
            entity.Property(e => e.EndVehicleTime)
                .HasMaxLength(8)
                .HasComment("막차시간")
                .HasColumnName("end_vehicle_time");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("이름")
                .HasColumnName("name");
            entity.Property(e => e.RouteNo)
                .HasMaxLength(16)
                .HasComment("노선번호")
                .HasColumnName("route_no");
            entity.Property(e => e.RouteTp)
                .HasMaxLength(16)
                .HasComment("노선유형")
                .HasColumnName("route_tp");
            entity.Property(e => e.StartNodeName)
                .HasMaxLength(32)
                .HasComment("기점")
                .HasColumnName("start_node_name");
            entity.Property(e => e.StartVehicleTime)
                .HasMaxLength(8)
                .HasComment("첫차시간")
                .HasColumnName("start_vehicle_time");
            entity.Property(e => e.UseYn)
                .HasComment("사용여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("use_yn");

            entity.HasOne(d => d.CityCodeNavigation).WithMany(p => p.BusTagoRouteInfos)
                .HasForeignKey(d => d.CityCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bus_tago_city_code_TO_bus_tago_route_info");
        });

        modelBuilder.Entity<BusTagoStopInfo>(entity =>
        {
            entity.HasKey(e => new { e.NodeId, e.RouteId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("bus_tago_stop_info", tb => tb.HasComment("버스타고 정류장 정보"));

            entity.HasIndex(e => e.RouteId, "FK_bus_tago_route_info_TO_bus_tago_stop_info");

            entity.Property(e => e.NodeId)
                .HasMaxLength(16)
                .HasComment("정류장ID")
                .HasColumnName("node_id");
            entity.Property(e => e.RouteId)
                .HasMaxLength(16)
                .HasComment("노선ID")
                .HasColumnName("route_id");
            entity.Property(e => e.GpsLati)
                .HasComment("위도")
                .HasColumnName("gps_lati");
            entity.Property(e => e.GpsLong)
                .HasComment("경도")
                .HasColumnName("gps_long");
            entity.Property(e => e.NodeName)
                .HasMaxLength(64)
                .HasComment("정류장이름")
                .HasColumnName("node_name");
            entity.Property(e => e.NodeNo)
                .HasComment("정류장번호")
                .HasColumnType("int(11)")
                .HasColumnName("node_no");
            entity.Property(e => e.NodeOrder)
                .HasComment("노드순서")
                .HasColumnType("int(11)")
                .HasColumnName("node_order");

            entity.HasOne(d => d.Route).WithMany(p => p.BusTagoStopInfos)
                .HasForeignKey(d => d.RouteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_bus_tago_route_info_TO_bus_tago_stop_info");
        });

        modelBuilder.Entity<BusTagoVehicle>(entity =>
        {
            entity.HasKey(e => e.VehicleNo).HasName("PRIMARY");

            entity.ToTable("bus_tago_vehicle", tb => tb.HasComment("버스타고 차량 목록"));

            entity.HasIndex(e => e.MemberOfficeFk, "FK_member_office_TO_bus_tago_vehicle");

            entity.Property(e => e.VehicleNo)
                .ValueGeneratedNever()
                .HasComment("차량번호")
                .HasColumnType("int(11)")
                .HasColumnName("vehicle_no");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("생성시간")
                .HasColumnType("timestamp")
                .HasColumnName("create_time");
            entity.Property(e => e.FuelTankCapacity)
                .HasDefaultValueSql("'33990'")
                .HasComment("연료탱크용량")
                .HasColumnType("int(11)")
                .HasColumnName("fuel_tank_capacity");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역(사업소) 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");

            entity.HasOne(d => d.MemberOfficeFkNavigation).WithMany(p => p.BusTagoVehicles)
                .HasForeignKey(d => d.MemberOfficeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_member_office_TO_bus_tago_vehicle");
        });

        modelBuilder.Entity<CalculationDefineCode>(entity =>
        {
            entity.HasKey(e => e.CodeId).HasName("PRIMARY");

            entity.ToTable("calculation_define_code", tb => tb.HasComment("계산식 정의 코드"));

            entity.Property(e => e.CodeId)
                .ValueGeneratedNever()
                .HasComment("코드ID")
                .HasColumnType("int(11)")
                .HasColumnName("code_id");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("이름")
                .HasColumnName("name");
        });

        modelBuilder.Entity<CalculationIndex>(entity =>
        {
            entity.HasKey(e => e.IndexId).HasName("PRIMARY");

            entity.ToTable("calculation_index", tb => tb.HasComment("계산 포인트 인덱스"));

            entity.HasIndex(e => e.AlarmPriorityFk, "FK_alarm_priority_TO_calculation_index");

            entity.HasIndex(e => e.UnitFk, "FK_calculation_index_unit_fk");

            entity.HasIndex(e => e.CeqTypeFk, "FK_ceq_type_TO_calculation_index");

            entity.HasIndex(e => e.DataTypeFk, "FK_data_type_TO_calculation_index");

            entity.HasIndex(e => e.PointTypeFk, "FK_point_type_TO_calculation_index");

            entity.HasIndex(e => e.StateGroupFk, "FK_state_group_TO_calculation_index");

            entity.Property(e => e.IndexId)
                .ValueGeneratedNever()
                .HasComment("인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("index_id");
            entity.Property(e => e.AlarmPriorityFk)
                .HasComment("알람 우선순위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_fk");
            entity.Property(e => e.AlarmTypeFk)
                .HasComment("alarm_type_fk")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_type_fk");
            entity.Property(e => e.CeqTypeFk)
                .HasComment("설비 종류 ID")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_fk");
            entity.Property(e => e.DataTypeFk)
                .HasComment("데이터 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("data_type_fk");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("영문 인덱스명")
                .HasColumnName("e_name");
            entity.Property(e => e.EditTime)
                .HasComment("포인트 편집 시간")
                .HasColumnType("timestamp")
                .HasColumnName("edit_time");
            entity.Property(e => e.Formula)
                .HasMaxLength(1024)
                .HasComment("계산식")
                .HasColumnName("formula");
            entity.Property(e => e.LimitMaxValue)
                .HasComment("최대 LIMIT 값")
                .HasColumnName("limit_max_value");
            entity.Property(e => e.LimitMinValue)
                .HasComment("최소 LIMIT 값")
                .HasColumnName("limit_min_value");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("인덱스명")
                .HasColumnName("name");
            entity.Property(e => e.Period)
                .HasComment("계산주기")
                .HasColumnType("int(11)")
                .HasColumnName("period");
            entity.Property(e => e.PointTypeFk)
                .HasComment("포인트 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("point_type_fk");
            entity.Property(e => e.StateGroupFk)
                .HasComment("상태 그룹 ID")
                .HasColumnType("int(11)")
                .HasColumnName("state_group_fk");
            entity.Property(e => e.UnitFk)
                .HasComment("단위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("unit_fk");

            entity.HasOne(d => d.AlarmPriorityFkNavigation).WithMany(p => p.CalculationIndices)
                .HasForeignKey(d => d.AlarmPriorityFk)
                .HasConstraintName("FK_alarm_priority_TO_calculation_index");

            entity.HasOne(d => d.CeqTypeFkNavigation).WithMany(p => p.CalculationIndices)
                .HasForeignKey(d => d.CeqTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ceq_type_TO_calculation_index");

            entity.HasOne(d => d.DataTypeFkNavigation).WithMany(p => p.CalculationIndices)
                .HasForeignKey(d => d.DataTypeFk)
                .HasConstraintName("FK_data_type_TO_calculation_index");

            entity.HasOne(d => d.PointTypeFkNavigation).WithMany(p => p.CalculationIndices)
                .HasForeignKey(d => d.PointTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_point_type_TO_calculation_index");

            entity.HasOne(d => d.StateGroupFkNavigation).WithMany(p => p.CalculationIndices)
                .HasForeignKey(d => d.StateGroupFk)
                .HasConstraintName("FK_state_group_TO_calculation_index");

            entity.HasOne(d => d.UnitFkNavigation).WithMany(p => p.CalculationIndices)
                .HasForeignKey(d => d.UnitFk)
                .HasConstraintName("FK_calculation_index_unit_fk");
        });

        modelBuilder.Entity<CeqCalculationDefine>(entity =>
        {
            entity.HasKey(e => new { e.Mrid, e.DynamicIndex })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("ceq_calculation_define", tb => tb.HasComment("설비단위계산포인트정의"));

            entity.Property(e => e.Mrid)
                .HasComment("설비 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("mrid");
            entity.Property(e => e.DynamicIndex)
                .HasComment("인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_index");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.Formula)
                .HasMaxLength(1024)
                .HasComment("계산식")
                .HasColumnName("formula");
            entity.Property(e => e.Period)
                .HasComment("계산주기")
                .HasColumnType("int(11)")
                .HasColumnName("period");
        });

        modelBuilder.Entity<CeqProperty>(entity =>
        {
            entity.HasKey(e => new { e.CeqId, e.ItemFk })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("ceq_property", tb => tb.HasComment("설비(CEQ)별 속성"));

            entity.HasIndex(e => e.ItemFk, "FK_model_item_index_TO_ceq_property");

            entity.Property(e => e.CeqId)
                .HasComment("개체 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("ceq_id");
            entity.Property(e => e.ItemFk)
                .HasComment("모델 아이템 ID")
                .HasColumnType("int(11)")
                .HasColumnName("item_fk");
            entity.Property(e => e.Seq)
                .HasComment("표시 순서")
                .HasColumnType("int(11)")
                .HasColumnName("seq");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .HasComment("값")
                .HasColumnName("value");

            entity.HasOne(d => d.Ceq).WithMany(p => p.CeqProperties)
                .HasForeignKey(d => d.CeqId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_conducting_equipment_TO_ceq_property");

            entity.HasOne(d => d.ItemFkNavigation).WithMany(p => p.CeqProperties)
                .HasForeignKey(d => d.ItemFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_model_item_index_TO_ceq_property");
        });

        modelBuilder.Entity<CeqType>(entity =>
        {
            entity.HasKey(e => e.CeqTypeId).HasName("PRIMARY");

            entity.ToTable("ceq_type", tb => tb.HasComment("설비 타입"));

            entity.HasIndex(e => e.CeqTypeGroupFk, "FK_ceq_type_group_TO_ceq_type");

            entity.HasIndex(e => e.ProtocolTypeFk, "FK_ceq_type_protocol_type_fk");

            entity.Property(e => e.CeqTypeId)
                .ValueGeneratedNever()
                .HasComment("설비 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_id");
            entity.Property(e => e.CeqTypeGroupFk)
                .HasComment("ceq_type_group_fk")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_group_fk");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("설비 영문 타입명")
                .HasColumnName("e_name");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("설비 타입명")
                .HasColumnName("name");
            entity.Property(e => e.ProtocolTypeFk)
                .HasComment("프로토콜 ID")
                .HasColumnType("int(11)")
                .HasColumnName("protocol_type_fk");

            entity.HasOne(d => d.CeqTypeGroupFkNavigation).WithMany(p => p.CeqTypes)
                .HasForeignKey(d => d.CeqTypeGroupFk)
                .HasConstraintName("FK_ceq_type_group_TO_ceq_type");

            entity.HasOne(d => d.ProtocolTypeFkNavigation).WithMany(p => p.CeqTypes)
                .HasForeignKey(d => d.ProtocolTypeFk)
                .HasConstraintName("FK_ceq_type_protocol_type_fk");
        });

        modelBuilder.Entity<CeqTypeGroup>(entity =>
        {
            entity.HasKey(e => e.CeqTypeGroupId).HasName("PRIMARY");

            entity.ToTable("ceq_type_group", tb => tb.HasComment("CEQ 타입 그룹"));

            entity.Property(e => e.CeqTypeGroupId)
                .ValueGeneratedNever()
                .HasComment("설비 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_group_id");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("설비 영문 타입명")
                .HasColumnName("e_name");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("설비 타입명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<CeqValue>(entity =>
        {
            entity.HasKey(e => new { e.CeqMrid, e.DynamicIndex })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("ceq_value", tb => tb.HasComment("설비 포인트 값 정보"));

            entity.HasIndex(e => e.PointTypeFk, "FK_ceq_value_point_type_fk");

            entity.Property(e => e.CeqMrid)
                .HasComment("설비 mrID")
                .HasColumnType("bigint(20)")
                .HasColumnName("ceq_mrid");
            entity.Property(e => e.DynamicIndex)
                .HasComment("동적 인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("dynamic_index");
            entity.Property(e => e.DeviceUptime)
                .HasComment("기기 업데이트 시간")
                .HasColumnType("timestamp")
                .HasColumnName("device_uptime");
            entity.Property(e => e.PointIndex)
                .HasComment("포인트 인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("point_index");
            entity.Property(e => e.PointTypeFk)
                .HasComment("포인트 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("point_type_fk");
            entity.Property(e => e.QualityValue)
                .HasComment("Quality 값")
                .HasColumnType("smallint(6)")
                .HasColumnName("quality_value");
            entity.Property(e => e.SaveTime)
                .HasComment("서버 업데이트 시간")
                .HasColumnType("timestamp")
                .HasColumnName("save_time");
            entity.Property(e => e.TagValue)
                .HasComment("TAG 값")
                .HasColumnType("smallint(6)")
                .HasColumnName("tag_value");
            entity.Property(e => e.Value)
                .HasComment("값")
                .HasColumnName("value");

            entity.HasOne(d => d.PointTypeFkNavigation).WithMany(p => p.CeqValues)
                .HasForeignKey(d => d.PointTypeFk)
                .HasConstraintName("FK_ceq_value_point_type_fk");
        });

        modelBuilder.Entity<CommType>(entity =>
        {
            entity.HasKey(e => e.CommTypeId).HasName("PRIMARY");

            entity.ToTable("comm_type", tb => tb.HasComment("통신 타입"));

            entity.Property(e => e.CommTypeId)
                .ValueGeneratedNever()
                .HasComment("통신 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("comm_type_id");
            entity.Property(e => e.ApplicationTimeout)
                .HasComment("어플리케이션 송신 대기 시간")
                .HasColumnType("int(11)")
                .HasColumnName("application_timeout");
            entity.Property(e => e.CommrateStandard)
                .HasComment("통신 성공률 기준값")
                .HasColumnType("int(11)")
                .HasColumnName("commrate_standard");
            entity.Property(e => e.HmiCmdTimeout)
                .HasComment("HMI 명령 타임아웃")
                .HasColumnType("int(11)")
                .HasColumnName("hmi_cmd_timeout");
            entity.Property(e => e.HmiFileCmdTimeout)
                .HasComment("HMI 파형 명령 타임아웃")
                .HasColumnType("int(11)")
                .HasColumnName("hmi_file_cmd_timeout");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("통신 타입명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<CommonIndex>(entity =>
        {
            entity.HasKey(e => e.IndexId).HasName("PRIMARY");

            entity.ToTable("common_index", tb => tb.HasComment("공통 인덱스 테이블"));

            entity.HasIndex(e => e.IndexGroupFk, "FK_common_index_group_TO_common_index");

            entity.HasIndex(e => e.DataTypeId, "FK_data_type_TO_common_index");

            entity.Property(e => e.IndexId)
                .ValueGeneratedNever()
                .HasComment("공통 인덱스ID")
                .HasColumnType("int(11)")
                .HasColumnName("index_id");
            entity.Property(e => e.DataTypeId)
                .HasComment("데이터 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("data_type_id");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("상태 계측 영문 인덱스명")
                .HasColumnName("e_name");
            entity.Property(e => e.IndexGroupFk)
                .HasComment("인덱스그룹")
                .HasColumnType("int(11)")
                .HasColumnName("index_group_fk");
            entity.Property(e => e.Length)
                .HasComment("데이터 크기")
                .HasColumnType("int(11)")
                .HasColumnName("length");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("상태 계측 인덱스명")
                .HasColumnName("name");

            entity.HasOne(d => d.DataType).WithMany(p => p.CommonIndices)
                .HasForeignKey(d => d.DataTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_data_type_TO_common_index");

            entity.HasOne(d => d.IndexGroupFkNavigation).WithMany(p => p.CommonIndices)
                .HasForeignKey(d => d.IndexGroupFk)
                .HasConstraintName("FK_common_index_group_TO_common_index");
        });

        modelBuilder.Entity<CommonIndexGroup>(entity =>
        {
            entity.HasKey(e => e.IndexGroupId).HasName("PRIMARY");

            entity.ToTable("common_index_group", tb => tb.HasComment("공통 인덱스 그룹"));

            entity.Property(e => e.IndexGroupId)
                .ValueGeneratedNever()
                .HasComment("그룹ID")
                .HasColumnType("int(11)")
                .HasColumnName("index_group_id");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("영문명")
                .HasColumnName("e_name");
            entity.Property(e => e.IsCreate)
                .HasComment("생성여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("is_create");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("그룹명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<CompanyCode>(entity =>
        {
            entity.HasKey(e => e.CompanyCodeId).HasName("PRIMARY");

            entity.ToTable("company_code", tb => tb.HasComment("회사 정보"));

            entity.Property(e => e.CompanyCodeId)
                .ValueGeneratedNever()
                .HasComment("회사 정보 ID")
                .HasColumnType("int(11)")
                .HasColumnName("company_code_id");
            entity.Property(e => e.BusinessNo)
                .HasMaxLength(32)
                .HasComment("사업자등록번호")
                .HasColumnName("business_no");
            entity.Property(e => e.CompanyNo)
                .HasComment("회사코드")
                .HasColumnType("int(11)")
                .HasColumnName("company_no");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("회사명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<ComputerGroup>(entity =>
        {
            entity.HasKey(e => e.ComputerGroupId).HasName("PRIMARY");

            entity.ToTable("computer_group", tb => tb.HasComment("컴퓨터 그룹"));

            entity.Property(e => e.ComputerGroupId)
                .ValueGeneratedNever()
                .HasComment("컴퓨터 그룹ID")
                .HasColumnType("int(11)")
                .HasColumnName("computer_group_id");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.IsDup)
                .HasComment("이중화구성여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("is_dup");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("컴퓨터 그룹명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<ComputerInfo>(entity =>
        {
            entity.HasKey(e => e.ComputerId).HasName("PRIMARY");

            entity.ToTable("computer_info", tb => tb.HasComment("컴퓨터 정보"));

            entity.HasIndex(e => e.AlarmPriorityFk, "FK_alarm_priority_TO_computer_info");

            entity.HasIndex(e => e.ComputerGroupFk, "FK_computer_group_TO_computer_info");

            entity.HasIndex(e => e.MemberOfficeFk, "FK_computer_info_member_office_fk");

            entity.HasIndex(e => e.StateGroupFk, "FK_state_group_TO_computer_info");

            entity.Property(e => e.ComputerId)
                .ValueGeneratedNever()
                .HasComment("컴퓨터 ID")
                .HasColumnType("int(11)")
                .HasColumnName("computer_id");
            entity.Property(e => e.AlarmPriorityFk)
                .HasComment("알람 우선순위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_fk");
            entity.Property(e => e.ComputerGroupFk)
                .HasComment("컴퓨터 그룹ID")
                .HasColumnType("int(11)")
                .HasColumnName("computer_group_fk");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("컴퓨터명")
                .HasColumnName("name");
            entity.Property(e => e.OsName)
                .HasMaxLength(64)
                .HasComment("OS 이름")
                .HasColumnName("os_name");
            entity.Property(e => e.OsVersion)
                .HasMaxLength(64)
                .HasComment("OS 버젼")
                .HasColumnName("os_version");
            entity.Property(e => e.StateGroupFk)
                .HasComment("상태 그룹 ID")
                .HasColumnType("int(11)")
                .HasColumnName("state_group_fk");
            entity.Property(e => e.UseFlag)
                .HasComment("사용 여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("use_flag");

            entity.HasOne(d => d.AlarmPriorityFkNavigation).WithMany(p => p.ComputerInfos)
                .HasForeignKey(d => d.AlarmPriorityFk)
                .HasConstraintName("FK_alarm_priority_TO_computer_info");

            entity.HasOne(d => d.ComputerGroupFkNavigation).WithMany(p => p.ComputerInfos)
                .HasForeignKey(d => d.ComputerGroupFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_computer_group_TO_computer_info");

            entity.HasOne(d => d.MemberOfficeFkNavigation).WithMany(p => p.ComputerInfos)
                .HasForeignKey(d => d.MemberOfficeFk)
                .HasConstraintName("FK_computer_info_member_office_fk");

            entity.HasOne(d => d.StateGroupFkNavigation).WithMany(p => p.ComputerInfos)
                .HasForeignKey(d => d.StateGroupFk)
                .HasConstraintName("FK_state_group_TO_computer_info");
        });

        modelBuilder.Entity<ComputerState>(entity =>
        {
            entity.HasKey(e => e.ComputerFk).HasName("PRIMARY");

            entity.ToTable("computer_state", tb => tb.HasComment("컴퓨터 상태"));

            entity.Property(e => e.ComputerFk)
                .ValueGeneratedNever()
                .HasComment("컴퓨터 ID")
                .HasColumnType("int(11)")
                .HasColumnName("computer_fk");
            entity.Property(e => e.ActiveState)
                .HasComment("활성화 상태(Active)")
                .HasColumnType("tinyint(4)")
                .HasColumnName("active_state");
            entity.Property(e => e.CpuRate)
                .HasComment("CPU 사용률(%)")
                .HasColumnName("cpu_rate");
            entity.Property(e => e.DiskTotal)
                .HasComment("전체 디스크 크기(MB)")
                .HasColumnType("bigint(20)")
                .HasColumnName("disk_total");
            entity.Property(e => e.DiskUsage)
                .HasComment("사용 디스크 크기(MB)")
                .HasColumnType("bigint(20)")
                .HasColumnName("disk_usage");
            entity.Property(e => e.MemTotal)
                .HasComment("전체 메모리 크기(MB)")
                .HasColumnType("bigint(20)")
                .HasColumnName("mem_total");
            entity.Property(e => e.MemUsage)
                .HasComment("사용 메모리 크기(MB)")
                .HasColumnType("bigint(20)")
                .HasColumnName("mem_usage");
            entity.Property(e => e.Status)
                .HasComment("상태")
                .HasColumnType("tinyint(4)")
                .HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasComment("갱신 시간")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");

            entity.HasOne(d => d.ComputerFkNavigation).WithOne(p => p.ComputerState)
                .HasForeignKey<ComputerState>(d => d.ComputerFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_computer_info_TO_computer_state");
        });

        modelBuilder.Entity<ConductingEquipment>(entity =>
        {
            entity.HasKey(e => e.Mrid).HasName("PRIMARY");

            entity.ToTable("conducting_equipment", tb => tb.HasComment("설비 정보"));

            entity.HasIndex(e => e.StationMrfk, "FK_conducting_equipment_station_mrfk");

            entity.HasIndex(e => e.DeviceFk, "FK_device_comm_unit_TO_conducting_equipment");

            entity.Property(e => e.Mrid)
                .ValueGeneratedNever()
                .HasComment("개체 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("mrid");
            entity.Property(e => e.CircuitNo)
                .HasComment("회로번호")
                .HasColumnType("tinyint(4)")
                .HasColumnName("circuit_no");
            entity.Property(e => e.DeviceFk)
                .HasComment("통신기기ID")
                .HasColumnType("int(11)")
                .HasColumnName("device_fk");
            entity.Property(e => e.StationMrfk)
                .HasComment("소속 스테이션 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("station_mrfk");

            entity.HasOne(d => d.DeviceFkNavigation).WithMany(p => p.ConductingEquipments)
                .HasForeignKey(d => d.DeviceFk)
                .HasConstraintName("FK_device_comm_unit_TO_conducting_equipment");

            entity.HasOne(d => d.Mr).WithOne(p => p.ConductingEquipment)
                .HasForeignKey<ConductingEquipment>(d => d.Mrid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_identity_object_TO_conducting_equipment");

            entity.HasOne(d => d.StationMrfkNavigation).WithMany(p => p.ConductingEquipments)
                .HasForeignKey(d => d.StationMrfk)
                .HasConstraintName("FK_conducting_equipment_station_mrfk");
        });

        modelBuilder.Entity<CounterIndex>(entity =>
        {
            entity.HasKey(e => e.IndexId).HasName("PRIMARY");

            entity.ToTable("counter_index", tb => tb.HasComment("카운터 표준 인텍스"));

            entity.HasIndex(e => e.AlarmPriorityFk, "FK_counter_index_alarm_priority_fk");

            entity.HasIndex(e => e.DataTypeFk, "FK_counter_index_data_type_fk");

            entity.HasIndex(e => e.ScaleFactorFk, "FK_counter_index_scale_factor_fk");

            entity.HasIndex(e => e.StateGroupFk, "FK_counter_index_state_group_fk");

            entity.HasIndex(e => e.UnitFk, "FK_counter_index_unit_fk");

            entity.HasIndex(e => e.EName, "UC_counter_index").IsUnique();

            entity.Property(e => e.IndexId)
                .ValueGeneratedNever()
                .HasComment("카운터 표준 인텍스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("index_id");
            entity.Property(e => e.AlarmPriorityFk)
                .HasComment("알람 우선순위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_fk");
            entity.Property(e => e.AlarmTypeFk)
                .HasDefaultValueSql("'0'")
                .HasComment("alarm_type_fk")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_type_fk");
            entity.Property(e => e.DataTypeFk)
                .HasComment("데이터 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("data_type_fk");
            entity.Property(e => e.Deadband)
                .HasComment("deadband 값")
                .HasColumnName("deadband");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("카운터 영문 인덱스명")
                .HasColumnName("e_name");
            entity.Property(e => e.LimitMaxValue)
                .HasComment("최대 LIMIT 값")
                .HasColumnName("limit_max_value");
            entity.Property(e => e.LimitMinValue)
                .HasComment("최소 LIMIT 값")
                .HasColumnName("limit_min_value");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("카운터 표준 인텍스명")
                .HasColumnName("name");
            entity.Property(e => e.ScaleFactorFk)
                .HasComment("스케일 펙터 ID")
                .HasColumnType("int(11)")
                .HasColumnName("scale_factor_fk");
            entity.Property(e => e.StateGroupFk)
                .HasComment("상태 그룹 ID")
                .HasColumnType("int(11)")
                .HasColumnName("state_group_fk");
            entity.Property(e => e.UnitFk)
                .HasComment("단위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("unit_fk");

            entity.HasOne(d => d.AlarmPriorityFkNavigation).WithMany(p => p.CounterIndices)
                .HasForeignKey(d => d.AlarmPriorityFk)
                .HasConstraintName("FK_counter_index_alarm_priority_fk");

            entity.HasOne(d => d.DataTypeFkNavigation).WithMany(p => p.CounterIndices)
                .HasForeignKey(d => d.DataTypeFk)
                .HasConstraintName("FK_counter_index_data_type_fk");

            entity.HasOne(d => d.ScaleFactorFkNavigation).WithMany(p => p.CounterIndices)
                .HasForeignKey(d => d.ScaleFactorFk)
                .HasConstraintName("FK_counter_index_scale_factor_fk");

            entity.HasOne(d => d.StateGroupFkNavigation).WithMany(p => p.CounterIndices)
                .HasForeignKey(d => d.StateGroupFk)
                .HasConstraintName("FK_counter_index_state_group_fk");

            entity.HasOne(d => d.UnitFkNavigation).WithMany(p => p.CounterIndices)
                .HasForeignKey(d => d.UnitFk)
                .HasConstraintName("FK_counter_index_unit_fk");
        });

        modelBuilder.Entity<DataType>(entity =>
        {
            entity.HasKey(e => e.DataTypeId).HasName("PRIMARY");

            entity.ToTable("data_type", tb => tb.HasComment("데이터 타입"));

            entity.Property(e => e.DataTypeId)
                .ValueGeneratedNever()
                .HasComment("데이터 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("data_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("데이터 타입명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<DerType>(entity =>
        {
            entity.HasKey(e => e.DerTypeId).HasName("PRIMARY");

            entity.ToTable("der_type", tb => tb.HasComment("분산전원 타입"));

            entity.Property(e => e.DerTypeId)
                .ValueGeneratedNever()
                .HasComment("분산전원 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("der_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("분산전원명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<DeviceCommConfig>(entity =>
        {
            entity.HasKey(e => e.DeviceFk).HasName("PRIMARY");

            entity.ToTable("device_comm_config", tb => tb.HasComment("원격통신기기설정"));

            entity.Property(e => e.DeviceFk)
                .ValueGeneratedNever()
                .HasComment("통신기기ID")
                .HasColumnType("int(11)")
                .HasColumnName("device_fk");
            entity.Property(e => e.AppRetryCount)
                .HasComment("재시도 수행횟수")
                .HasColumnType("int(11)")
                .HasColumnName("app_retry_count");
            entity.Property(e => e.AppRetryTimeout)
                .HasComment("재시도 타임아웃")
                .HasColumnType("int(11)")
                .HasColumnName("app_retry_timeout");
            entity.Property(e => e.AppSendTimeout)
                .HasComment("전송 타임아웃")
                .HasColumnType("int(11)")
                .HasColumnName("app_send_timeout");
            entity.Property(e => e.CommStatusInterval)
                .HasComment("통신상태전송주기")
                .HasColumnType("int(11)")
                .HasColumnName("comm_status_interval");
            entity.Property(e => e.EventInterval)
                .HasComment("이벤트 계측 주기")
                .HasColumnType("int(11)")
                .HasColumnName("event_interval");
            entity.Property(e => e.ParameterProperty)
                .HasMaxLength(256)
                .HasComment("파라메터 속성값")
                .HasColumnName("parameter_property");
            entity.Property(e => e.TotalInterval)
                .HasComment("전체계측 주기")
                .HasColumnType("int(11)")
                .HasColumnName("total_interval");

            entity.HasOne(d => d.DeviceFkNavigation).WithOne(p => p.DeviceCommConfig)
                .HasForeignKey<DeviceCommConfig>(d => d.DeviceFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_device_comm_unit_TO_device_comm_config");
        });

        modelBuilder.Entity<DeviceCommUnit>(entity =>
        {
            entity.HasKey(e => e.DeviceId).HasName("PRIMARY");

            entity.ToTable("device_comm_unit", tb => tb.HasComment("원격통신기기"));

            entity.HasIndex(e => e.CeqTypeGroupFk, "FK_ceq_type_group_TO_device_comm_unit");

            entity.HasIndex(e => e.CommTypeFk, "FK_comm_type_TO_device_comm_unit");

            entity.Property(e => e.DeviceId)
                .ValueGeneratedNever()
                .HasComment("통신기기ID")
                .HasColumnType("int(11)")
                .HasColumnName("device_id");
            entity.Property(e => e.CeqTypeGroupFk)
                .HasComment("ceq_type_group_fk")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_group_fk");
            entity.Property(e => e.CommTypeFk)
                .HasComment("통신 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("comm_type_fk");
            entity.Property(e => e.FepId)
                .HasComment("FEP 프로그램 ID")
                .HasColumnType("int(11)")
                .HasColumnName("fep_id");
            entity.Property(e => e.FrtuAddr)
                .HasComment("FRTU 주소")
                .HasColumnType("int(11)")
                .HasColumnName("frtu_addr");
            entity.Property(e => e.MasterAddr)
                .HasComment("마스터주소")
                .HasColumnType("int(11)")
                .HasColumnName("master_addr");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("이름")
                .HasColumnName("name");
            entity.Property(e => e.SimulAddress)
                .HasMaxLength(32)
                .HasComment("시뮬 연결 TCP 주소")
                .HasColumnName("simul_address");
            entity.Property(e => e.SimulPort)
                .HasComment("시뮬 연결 TCP 포트")
                .HasColumnType("int(11)")
                .HasColumnName("simul_port");
            entity.Property(e => e.SimulUsage)
                .HasComment("시뮬레이터 사용여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("simul_usage");
            entity.Property(e => e.TcpAddress)
                .HasMaxLength(32)
                .HasComment("원격 연결 TCP 주소")
                .HasColumnName("tcp_address");
            entity.Property(e => e.TcpPort)
                .HasComment("원격 연결 TCP 포트")
                .HasColumnType("int(11)")
                .HasColumnName("tcp_port");

            entity.HasOne(d => d.CeqTypeGroupFkNavigation).WithMany(p => p.DeviceCommUnits)
                .HasForeignKey(d => d.CeqTypeGroupFk)
                .HasConstraintName("FK_ceq_type_group_TO_device_comm_unit");

            entity.HasOne(d => d.CommTypeFkNavigation).WithMany(p => p.DeviceCommUnits)
                .HasForeignKey(d => d.CommTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_comm_type_TO_device_comm_unit");
        });

        modelBuilder.Entity<DevicePointScenario>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PRIMARY");

            entity.ToTable("device_point_scenario", tb => tb.HasComment("디바이스 포인트 시나리오"));

            entity.Property(e => e.Idx)
                .ValueGeneratedNever()
                .HasComment("로그인덱스")
                .HasColumnType("bigint(20)")
                .HasColumnName("idx");
            entity.Property(e => e.CeqTypeId)
                .HasComment("CEQ 타입")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_id");
            entity.Property(e => e.CircuitNo)
                .HasComment("회로번호")
                .HasColumnType("tinyint(4)")
                .HasColumnName("circuit_no");
            entity.Property(e => e.DeviceId)
                .HasComment("디바이스 아이디")
                .HasColumnType("int(11)")
                .HasColumnName("device_id");
            entity.Property(e => e.IndexName)
                .HasMaxLength(64)
                .HasComment("포인트 영문명")
                .HasColumnName("index_name");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("시나리오 이름")
                .HasColumnName("name");
            entity.Property(e => e.ScenarioPattern)
                .HasComment("시나리오 패턴(1: 일반 2: 증가 11: 년 12: 월 13:시 14:분 15: 초)")
                .HasColumnType("tinyint(4)")
                .HasColumnName("scenario_pattern");
            entity.Property(e => e.ScenarioType)
                .HasComment("시나리오 타입 (1: 개별, 2: CEQ 타입별)")
                .HasColumnType("tinyint(4)")
                .HasColumnName("scenario_type");
            entity.Property(e => e.SetValues)
                .HasMaxLength(512)
                .HasComment("포인트 설정값")
                .HasColumnName("set_values");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<DeviceScenarioType>(entity =>
        {
            entity.HasKey(e => e.ScenarioTypeId).HasName("PRIMARY");

            entity.ToTable("device_scenario_type", tb => tb.HasComment("디바이스 시나리오 타입"));

            entity.Property(e => e.ScenarioTypeId)
                .ValueGeneratedNever()
                .HasComment("시나리오타입ID")
                .HasColumnType("int(11)")
                .HasColumnName("scenario_type_id");
            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("시나리오타입이름")
                .HasColumnName("name");
        });

        modelBuilder.Entity<DvrSystem>(entity =>
        {
            entity.HasKey(e => e.DvrId).HasName("PRIMARY");

            entity.ToTable("dvr_system", tb => tb.HasComment("DVR 시스템"));

            entity.HasIndex(e => e.StationFk, "FK_substation_TO_dvr_system");

            entity.Property(e => e.DvrId)
                .ValueGeneratedNever()
                .HasComment("DVR ID")
                .HasColumnType("int(11)")
                .HasColumnName("dvr_id");
            entity.Property(e => e.DvrIp)
                .HasMaxLength(32)
                .HasComment("DVR IP")
                .HasColumnName("dvr_ip");
            entity.Property(e => e.DvrNo)
                .HasMaxLength(8)
                .HasComment("DVR 번호")
                .HasColumnName("dvr_no");
            entity.Property(e => e.DvrPort)
                .HasComment("DVR PORT")
                .HasColumnType("int(11)")
                .HasColumnName("dvr_port");
            entity.Property(e => e.OdtNo)
                .HasComment("ODT 번호")
                .HasColumnType("int(11)")
                .HasColumnName("odt_no");
            entity.Property(e => e.StationFk)
                .HasComment("스테이션 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("station_fk");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");

            entity.HasOne(d => d.StationFkNavigation).WithMany(p => p.DvrSystems)
                .HasForeignKey(d => d.StationFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_substation_TO_dvr_system");
        });

        modelBuilder.Entity<GroupOffice>(entity =>
        {
            entity.HasKey(e => e.GroupOfficeId).HasName("PRIMARY");

            entity.ToTable("group_office", tb => tb.HasComment("그룹 사업소"));

            entity.Property(e => e.GroupOfficeId)
                .ValueGeneratedNever()
                .HasComment("그룹사업소 ID")
                .HasColumnType("int(11)")
                .HasColumnName("group_office_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("이름")
                .HasColumnName("name");
        });

        modelBuilder.Entity<IdentityObject>(entity =>
        {
            entity.HasKey(e => e.Mrid).HasName("PRIMARY");

            entity.ToTable("identity_object", tb => tb.HasComment("개체 식별 정보"));

            entity.HasIndex(e => e.ModelFk, "FK_identity_object_model_fk");

            entity.Property(e => e.Mrid)
                .ValueGeneratedNever()
                .HasComment("개체 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("mrid");
            entity.Property(e => e.AliasName)
                .HasMaxLength(64)
                .HasComment("별칭")
                .HasColumnName("alias_name");
            entity.Property(e => e.ModelFk)
                .HasComment("연결 모델 ID")
                .HasColumnType("int(11)")
                .HasColumnName("model_fk");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("개체명")
                .HasColumnName("name");

            entity.HasOne(d => d.ModelFkNavigation).WithMany(p => p.IdentityObjects)
                .HasForeignKey(d => d.ModelFk)
                .HasConstraintName("FK_identity_object_model_fk");
        });

        modelBuilder.Entity<LogBusOperation>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.ToTable("log_bus_operation", tb => tb.HasComment("버스운영상태로그"));

            entity.Property(e => e.LogId)
                .HasComment("로그ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("log_id");
            entity.Property(e => e.AfterFuelAmount)
                .HasComment("연료충전완료후량")
                .HasColumnType("int(11)")
                .HasColumnName("after_fuel_amount");
            entity.Property(e => e.CityCode)
                .HasComment("도시코드")
                .HasColumnType("int(11)")
                .HasColumnName("city_code");
            entity.Property(e => e.DeviceUpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("device_update_time");
            entity.Property(e => e.EventMsg)
                .HasMaxLength(256)
                .HasComment("메시지")
                .HasColumnName("event_msg");
            entity.Property(e => e.FuelInjectionDate)
                .HasComment("연료주입일")
                .HasColumnType("timestamp")
                .HasColumnName("fuel_injection_date");
            entity.Property(e => e.FuelInjectionMileage)
                .HasComment("연료주입시총주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("fuel_injection_mileage");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.NewRunStop)
                .HasComment("메시지")
                .HasColumnType("tinyint(4)")
                .HasColumnName("new_run_stop");
            entity.Property(e => e.OldRunStop)
                .HasComment("사용여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("old_run_stop");
            entity.Property(e => e.RouteId)
                .HasMaxLength(16)
                .HasComment("노선ID")
                .HasColumnName("route_id");
            entity.Property(e => e.TotalMileage)
                .HasComment("전체주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("total_mileage");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
            entity.Property(e => e.VehicleNo)
                .HasComment("차량번호")
                .HasColumnType("int(11)")
                .HasColumnName("vehicle_no");
        });

        modelBuilder.Entity<LogComputer>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.ToTable("log_computer", tb => tb.HasComment("컴퓨터 상태 로그"));

            entity.Property(e => e.LogId)
                .HasComment("로그ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("log_id");
            entity.Property(e => e.ComputerId)
                .HasComment("컴퓨터 ID")
                .HasColumnType("int(11)")
                .HasColumnName("computer_id");
            entity.Property(e => e.CpuRate)
                .HasComment("CPU 사용률(%)")
                .HasColumnName("cpu_rate");
            entity.Property(e => e.DiskTotal)
                .HasComment("전체 디스크 크기(MB)")
                .HasColumnType("bigint(20)")
                .HasColumnName("disk_total");
            entity.Property(e => e.DiskUsage)
                .HasComment("사용 디스크 크기(MB)")
                .HasColumnType("bigint(20)")
                .HasColumnName("disk_usage");
            entity.Property(e => e.EventMsg)
                .HasMaxLength(256)
                .HasComment("메시지")
                .HasColumnName("event_msg");
            entity.Property(e => e.MemTotal)
                .HasComment("전체 메모리 크기(MB)")
                .HasColumnType("bigint(20)")
                .HasColumnName("mem_total");
            entity.Property(e => e.MemUsage)
                .HasComment("사용 메모리 크기(MB)")
                .HasColumnType("bigint(20)")
                .HasColumnName("mem_usage");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.NewActiveState)
                .HasComment("활성화 상태(Active)")
                .HasColumnType("tinyint(4)")
                .HasColumnName("new_active_state");
            entity.Property(e => e.NewStatus)
                .HasComment("상태")
                .HasColumnType("tinyint(4)")
                .HasColumnName("new_status");
            entity.Property(e => e.OldActiveState)
                .HasComment("활성화 상태(Active)")
                .HasColumnType("tinyint(4)")
                .HasColumnName("old_active_state");
            entity.Property(e => e.OldStatus)
                .HasComment("상태")
                .HasColumnType("tinyint(4)")
                .HasColumnName("old_status");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<LogControl>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.ToTable("log_control", tb => tb.HasComment("제어 수행로그"));

            entity.Property(e => e.LogId)
                .HasComment("로그ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("log_id");
            entity.Property(e => e.CeqFk)
                .HasComment("설비 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("ceq_fk");
            entity.Property(e => e.CeqTypeFk)
                .HasComment("설비 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_fk");
            entity.Property(e => e.ControlResult)
                .HasComment("제어 결과(0:실패, 1:성공)")
                .HasColumnType("int(11)")
                .HasColumnName("control_result");
            entity.Property(e => e.ControlResultMessage)
                .HasMaxLength(128)
                .HasComment("제어 결과 메시지")
                .HasColumnName("control_result_message");
            entity.Property(e => e.ControlResultTime)
                .HasComment("제어 결과 시간")
                .HasColumnType("timestamp")
                .HasColumnName("control_result_time");
            entity.Property(e => e.ControlTime)
                .HasComment("제어 수행 시간")
                .HasColumnType("timestamp")
                .HasColumnName("control_time");
            entity.Property(e => e.ControlUserFk)
                .HasMaxLength(64)
                .HasComment("사용자 ID")
                .HasColumnName("control_user_fk");
            entity.Property(e => e.DdataIndexFk)
                .HasComment("동적인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("ddata_index_fk");
            entity.Property(e => e.DeviceCeqFk)
                .HasComment("연결 기기 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("device_ceq_fk");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.NewValue)
                .HasComment("현재값")
                .HasColumnName("new_value");
            entity.Property(e => e.PointIndexFk)
                .HasComment("포인트 인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("point_index_fk");
            entity.Property(e => e.PointTypeFk)
                .HasComment("포인트 타입 ID")
                .HasColumnType("tinyint(4)")
                .HasColumnName("point_type_fk");
            entity.Property(e => e.StationFk)
                .HasComment("변전소 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("station_fk");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<LogDeviceComm>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.ToTable("log_device_comm", tb => tb.HasComment("원격 설비 통신 로그"));

            entity.Property(e => e.LogId)
                .HasComment("로그ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("log_id");
            entity.Property(e => e.CeqFk)
                .HasComment("연결 기기 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("ceq_fk");
            entity.Property(e => e.CommFailCnt)
                .HasComment("통신 실패 개수")
                .HasColumnType("int(11)")
                .HasColumnName("comm_fail_cnt");
            entity.Property(e => e.CommNoResponseCnt)
                .HasComment("무응답 개수")
                .HasColumnType("int(11)")
                .HasColumnName("comm_no_response_cnt");
            entity.Property(e => e.CommSucessCnt)
                .HasComment("통신 성공 개수")
                .HasColumnType("int(11)")
                .HasColumnName("comm_sucess_cnt");
            entity.Property(e => e.CommTotalCnt)
                .HasComment("전체 통신 수행 횟수")
                .HasColumnType("int(11)")
                .HasColumnName("comm_total_cnt");
            entity.Property(e => e.DeviceFk)
                .HasComment("통신기기ID")
                .HasColumnType("int(11)")
                .HasColumnName("device_fk");
            entity.Property(e => e.EventMsg)
                .HasMaxLength(256)
                .HasComment("메시지")
                .HasColumnName("event_msg");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.NewCommState)
                .HasComment("통신상태")
                .HasColumnType("tinyint(4)")
                .HasColumnName("new_comm_state");
            entity.Property(e => e.OldCommState)
                .HasComment("통신상태")
                .HasColumnType("tinyint(4)")
                .HasColumnName("old_comm_state");
            entity.Property(e => e.StationFk)
                .HasComment("변전소 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("station_fk");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<LogEvent>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.ToTable("log_event", tb => tb.HasComment("이벤트 로그"));

            entity.Property(e => e.LogId)
                .HasComment("로그 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("log_id");
            entity.Property(e => e.Ack)
                .HasComment("ACK")
                .HasColumnType("tinyint(4)")
                .HasColumnName("ack");
            entity.Property(e => e.AckTime)
                .HasComment("ACK 타임")
                .HasColumnType("timestamp")
                .HasColumnName("ack_time");
            entity.Property(e => e.AckUserFk)
                .HasMaxLength(64)
                .HasComment("ACK 사용자 ID")
                .HasColumnName("ack_user_fk");
            entity.Property(e => e.AlarmPriority)
                .HasComment("알람 우선순위")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority");
            entity.Property(e => e.CeqFk)
                .HasComment("설비 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("ceq_fk");
            entity.Property(e => e.CeqTypeFk)
                .HasComment("설비 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_fk");
            entity.Property(e => e.CircuitNo)
                .HasComment("회로번호")
                .HasColumnType("tinyint(4)")
                .HasColumnName("circuit_no");
            entity.Property(e => e.DdataIndexFk)
                .HasComment("동적인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("ddata_index_fk");
            entity.Property(e => e.DeviceCeqFk)
                .HasComment("연결 기기 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("device_ceq_fk");
            entity.Property(e => e.DeviceEventTime)
                .HasComment("연결 기기 발생 시간")
                .HasColumnType("timestamp")
                .HasColumnName("device_event_time");
            entity.Property(e => e.EventCreateTime)
                .HasComment("서버 발생 시간")
                .HasColumnType("timestamp")
                .HasColumnName("event_create_time");
            entity.Property(e => e.EventId)
                .HasComment("이벤트 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("event_id");
            entity.Property(e => e.EventMsg)
                .HasMaxLength(256)
                .HasComment("메시지")
                .HasColumnName("event_msg");
            entity.Property(e => e.EventTypeFk)
                .HasComment("이벤트 타입")
                .HasColumnType("int(11)")
                .HasColumnName("event_type_fk");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.NewValue)
                .HasComment("현재값")
                .HasColumnName("new_value");
            entity.Property(e => e.OldValue)
                .HasComment("이전값")
                .HasColumnName("old_value");
            entity.Property(e => e.PointIndexFk)
                .HasComment("포인트 인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("point_index_fk");
            entity.Property(e => e.PointTypeFk)
                .HasComment("포인트 타입 ID")
                .HasColumnType("tinyint(4)")
                .HasColumnName("point_type_fk");
            entity.Property(e => e.QualityValue)
                .HasComment("Quality 값")
                .HasColumnType("int(11)")
                .HasColumnName("quality_value");
            entity.Property(e => e.StationFk)
                .HasComment("변전소 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("station_fk");
            entity.Property(e => e.TagValue)
                .HasComment("TAG 값")
                .HasColumnType("int(11)")
                .HasColumnName("tag_value");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<LogProgram>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.ToTable("log_program", tb => tb.HasComment("프로그램 상태 로그"));

            entity.Property(e => e.LogId)
                .HasComment("로그ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("log_id");
            entity.Property(e => e.EndTime)
                .HasComment("종료시간")
                .HasColumnType("timestamp")
                .HasColumnName("end_time");
            entity.Property(e => e.EventMsg)
                .HasMaxLength(256)
                .HasComment("메시지")
                .HasColumnName("event_msg");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.NewStatus)
                .HasComment("상태")
                .HasColumnType("tinyint(4)")
                .HasColumnName("new_status");
            entity.Property(e => e.OldStatus)
                .HasComment("상태")
                .HasColumnType("tinyint(4)")
                .HasColumnName("old_status");
            entity.Property(e => e.ProgramId)
                .HasComment("프로그램 ID")
                .HasColumnType("int(11)")
                .HasColumnName("program_id");
            entity.Property(e => e.StartTime)
                .HasComment("시작시간")
                .HasColumnType("timestamp")
                .HasColumnName("start_time");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("갱신시간")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<LogSnmp>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.ToTable("log_snmp", tb => tb.HasComment("컴퓨터 상태 로그"));

            entity.Property(e => e.LogId)
                .HasComment("로그ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("log_id");
            entity.Property(e => e.CpuRate)
                .HasComment("CPU 사용률(%)")
                .HasColumnName("cpu_rate");
            entity.Property(e => e.DiskRate)
                .HasComment("DISK 사용률(%)")
                .HasColumnName("disk_rate");
            entity.Property(e => e.EventMsg)
                .HasMaxLength(256)
                .HasComment("메시지")
                .HasColumnName("event_msg");
            entity.Property(e => e.MemRate)
                .HasComment("MEM 사용률(%)")
                .HasColumnName("mem_rate");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.NewStatus)
                .HasComment("상태")
                .HasColumnType("tinyint(4)")
                .HasColumnName("new_status");
            entity.Property(e => e.OldStatus)
                .HasComment("상태")
                .HasColumnType("tinyint(4)")
                .HasColumnName("old_status");
            entity.Property(e => e.PortId)
                .HasMaxLength(512)
                .HasComment("포트 아이디")
                .HasColumnName("port_id");
            entity.Property(e => e.PortValue)
                .HasMaxLength(512)
                .HasComment("포트 값")
                .HasColumnName("port_value");
            entity.Property(e => e.SnmpId)
                .HasComment("SNMP ID")
                .HasColumnType("int(11)")
                .HasColumnName("snmp_id");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<LogSystem>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.ToTable("log_system", tb => tb.HasComment("시스템 로그"));

            entity.Property(e => e.LogId)
                .HasComment("로그ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("log_id");
            entity.Property(e => e.MsgTypeId)
                .HasComment("메시지 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("msg_type_id");
            entity.Property(e => e.ReqProcName)
                .HasMaxLength(64)
                .HasComment("요청 프로그램 이름")
                .HasColumnName("req_proc_name");
            entity.Property(e => e.ReqTime)
                .HasMaxLength(32)
                .HasComment("요청 시간")
                .HasColumnName("req_time");
            entity.Property(e => e.ResProcName)
                .HasMaxLength(64)
                .HasComment("응답(수행) 프로그램 이름")
                .HasColumnName("res_proc_name");
            entity.Property(e => e.ResTime)
                .HasMaxLength(32)
                .HasComment("응답시간")
                .HasColumnName("res_time");
            entity.Property(e => e.ResultCode)
                .HasMaxLength(8)
                .HasComment("결과코드")
                .HasColumnName("result_code");
            entity.Property(e => e.ResultMessage)
                .HasMaxLength(256)
                .HasComment("결과 메시지")
                .HasColumnName("result_message");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<MasterIndex>(entity =>
        {
            entity.HasKey(e => e.MasterIndexId).HasName("PRIMARY");

            entity.ToTable("master_index", tb => tb.HasComment("마스터 인덱스"));

            entity.HasIndex(e => e.AlarmPriorityFk, "FK_master_index_alarm_priority_fk");

            entity.HasIndex(e => e.CeqTypeFk, "FK_master_index_ceq_type_fk");

            entity.HasIndex(e => e.DataTypeFk, "FK_master_index_data_type_fk");

            entity.HasIndex(e => e.PointTypeFk, "FK_master_index_point_type_fk");

            entity.HasIndex(e => e.ScaleFactorFk, "FK_master_index_scale_factor_fk");

            entity.HasIndex(e => e.StateGroupFk, "FK_master_index_state_group_fk");

            entity.HasIndex(e => e.UnitFk, "FK_master_index_unit_fk");

            entity.Property(e => e.MasterIndexId)
                .ValueGeneratedNever()
                .HasComment("마스터 인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("master_index_id");
            entity.Property(e => e.AlarmPriorityFk)
                .HasComment("알람 우선순위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_fk");
            entity.Property(e => e.BitPosition)
                .HasComment("비트 포지션")
                .HasColumnType("tinyint(4)")
                .HasColumnName("bit_position");
            entity.Property(e => e.CeqTypeFk)
                .HasComment("설비 종류 ID")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_fk");
            entity.Property(e => e.CircuitNo)
                .HasComment("회로 번호")
                .HasColumnType("int(11)")
                .HasColumnName("circuit_no");
            entity.Property(e => e.ClassNo)
                .HasComment("클래스번호_REG_TYPE")
                .HasColumnType("int(11)")
                .HasColumnName("class_no");
            entity.Property(e => e.DataTypeFk)
                .HasComment("데이터 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("data_type_fk");
            entity.Property(e => e.Deadband)
                .HasComment("deadband 값")
                .HasColumnName("deadband");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.IndexFk)
                .HasComment("포인트 타입별 인덱스 ID")
                .HasColumnType("int(11)")
                .HasColumnName("index_fk");
            entity.Property(e => e.LimitMaxValue)
                .HasComment("최대 LIMIT 값")
                .HasColumnName("limit_max_value");
            entity.Property(e => e.LimitMinValue)
                .HasComment("최소 LIMIT 값")
                .HasColumnName("limit_min_value");
            entity.Property(e => e.ModbusAddress)
                .HasComment("모드버스ADDR")
                .HasColumnType("int(11)")
                .HasColumnName("modbus_address");
            entity.Property(e => e.ObjVar)
                .HasMaxLength(64)
                .HasComment("object_variation")
                .HasColumnName("obj_var");
            entity.Property(e => e.PointTypeFk)
                .HasComment("포인트 타입")
                .HasColumnType("int(11)")
                .HasColumnName("point_type_fk");
            entity.Property(e => e.RemoteAddress)
                .HasComment("프로토콜 의존적인 Remote Address 정보")
                .HasColumnType("int(11)")
                .HasColumnName("remote_address");
            entity.Property(e => e.ScaleFactorFk)
                .HasComment("스케일 펙터 ID")
                .HasColumnType("int(11)")
                .HasColumnName("scale_factor_fk");
            entity.Property(e => e.StateGroupFk)
                .HasComment("상태 그룹 ID")
                .HasColumnType("int(11)")
                .HasColumnName("state_group_fk");
            entity.Property(e => e.UnitFk)
                .HasComment("단위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("unit_fk");

            entity.HasOne(d => d.AlarmPriorityFkNavigation).WithMany(p => p.MasterIndices)
                .HasForeignKey(d => d.AlarmPriorityFk)
                .HasConstraintName("FK_master_index_alarm_priority_fk");

            entity.HasOne(d => d.CeqTypeFkNavigation).WithMany(p => p.MasterIndices)
                .HasForeignKey(d => d.CeqTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_master_index_ceq_type_fk");

            entity.HasOne(d => d.DataTypeFkNavigation).WithMany(p => p.MasterIndices)
                .HasForeignKey(d => d.DataTypeFk)
                .HasConstraintName("FK_master_index_data_type_fk");

            entity.HasOne(d => d.PointTypeFkNavigation).WithMany(p => p.MasterIndices)
                .HasForeignKey(d => d.PointTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_master_index_point_type_fk");

            entity.HasOne(d => d.ScaleFactorFkNavigation).WithMany(p => p.MasterIndices)
                .HasForeignKey(d => d.ScaleFactorFk)
                .HasConstraintName("FK_master_index_scale_factor_fk");

            entity.HasOne(d => d.StateGroupFkNavigation).WithMany(p => p.MasterIndices)
                .HasForeignKey(d => d.StateGroupFk)
                .HasConstraintName("FK_master_index_state_group_fk");

            entity.HasOne(d => d.UnitFkNavigation).WithMany(p => p.MasterIndices)
                .HasForeignKey(d => d.UnitFk)
                .HasConstraintName("FK_master_index_unit_fk");
        });

        modelBuilder.Entity<MemberOffice>(entity =>
        {
            entity.HasKey(e => e.MemberOfficeId).HasName("PRIMARY");

            entity.ToTable("member_office", tb => tb.HasComment("지역(사업소) 정보"));

            entity.HasIndex(e => e.GroupOfficeFk, "FK_group_office_TO_member_office");

            entity.Property(e => e.MemberOfficeId)
                .ValueGeneratedNever()
                .HasComment("지역(사업소) 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_id");
            entity.Property(e => e.GroupOfficeFk)
                .HasComment("그룹사업소 ID")
                .HasColumnType("int(11)")
                .HasColumnName("group_office_fk");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("지역(사업소) 명")
                .HasColumnName("name");
            entity.Property(e => e.OfficeType)
                .HasComment("지역(사업소) 타입")
                .HasColumnType("tinyint(4)")
                .HasColumnName("office_type");

            entity.HasOne(d => d.GroupOfficeFkNavigation).WithMany(p => p.MemberOffices)
                .HasForeignKey(d => d.GroupOfficeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_group_office_TO_member_office");
        });

        modelBuilder.Entity<ModbusSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PRIMARY");

            entity.ToTable("modbus_schedule", tb => tb.HasComment("모드버스 스케쥴"));

            entity.HasIndex(e => e.CeqTypeGroupFk, "FK_ceq_type_group_TO_modbus_schedule");

            entity.Property(e => e.ScheduleId)
                .ValueGeneratedNever()
                .HasComment("스케쥴ID")
                .HasColumnType("int(11)")
                .HasColumnName("schedule_id");
            entity.Property(e => e.CeqTypeGroupFk)
                .HasComment("설비 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_group_fk");
            entity.Property(e => e.FunctionCode)
                .HasComment("함수코드")
                .HasColumnType("int(11)")
                .HasColumnName("function_code");
            entity.Property(e => e.MeasureCount)
                .HasComment("계측 개수")
                .HasColumnType("int(11)")
                .HasColumnName("measure_count");
            entity.Property(e => e.OrderNo)
                .HasComment("계측 순서")
                .HasColumnType("int(11)")
                .HasColumnName("order_no");
            entity.Property(e => e.StartAddress)
                .HasComment("시작주소")
                .HasColumnType("int(11)")
                .HasColumnName("start_address");

            entity.HasOne(d => d.CeqTypeGroupFkNavigation).WithMany(p => p.ModbusSchedules)
                .HasForeignKey(d => d.CeqTypeGroupFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ceq_type_group_TO_modbus_schedule");
        });

        modelBuilder.Entity<ModelIndex>(entity =>
        {
            entity.HasKey(e => new { e.ModelFk, e.ItemFk })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("model_index", tb => tb.HasComment("모델 인덱스 정보"));

            entity.HasIndex(e => e.ItemFk, "FK_model_index_item_fk");

            entity.Property(e => e.ModelFk)
                .HasComment("모델 ID")
                .HasColumnType("int(11)")
                .HasColumnName("model_fk");
            entity.Property(e => e.ItemFk)
                .HasComment("모델 아이템 ID")
                .HasColumnType("int(11)")
                .HasColumnName("item_fk");
            entity.Property(e => e.Seq)
                .HasComment("표시 순서")
                .HasColumnType("int(11)")
                .HasColumnName("seq");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .HasComment("값")
                .HasColumnName("value");

            entity.HasOne(d => d.ItemFkNavigation).WithMany(p => p.ModelIndices)
                .HasForeignKey(d => d.ItemFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_model_index_item_fk");

            entity.HasOne(d => d.ModelFkNavigation).WithMany(p => p.ModelIndices)
                .HasForeignKey(d => d.ModelFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_model_index_model_fk");
        });

        modelBuilder.Entity<ModelInfo>(entity =>
        {
            entity.HasKey(e => e.ModelId).HasName("PRIMARY");

            entity.ToTable("model_info", tb => tb.HasComment("모델 정보"));

            entity.HasIndex(e => e.CeqTypeFk, "FK_ceq_type_TO_model_info");

            entity.HasIndex(e => e.ObjectTypeFk, "FK_model_info_object_type_fk");

            entity.Property(e => e.ModelId)
                .ValueGeneratedNever()
                .HasComment("모델 ID")
                .HasColumnType("int(11)")
                .HasColumnName("model_id");
            entity.Property(e => e.CeqTypeFk)
                .HasComment("설비 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_fk");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("모델명")
                .HasColumnName("name");
            entity.Property(e => e.ObjectTypeFk)
                .HasComment("개체 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("object_type_fk");

            entity.HasOne(d => d.CeqTypeFkNavigation).WithMany(p => p.ModelInfos)
                .HasForeignKey(d => d.CeqTypeFk)
                .HasConstraintName("FK_ceq_type_TO_model_info");

            entity.HasOne(d => d.ObjectTypeFkNavigation).WithMany(p => p.ModelInfos)
                .HasForeignKey(d => d.ObjectTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_model_info_object_type_fk");
        });

        modelBuilder.Entity<ModelItemIndex>(entity =>
        {
            entity.HasKey(e => e.IndexId).HasName("PRIMARY");

            entity.ToTable("model_item_index", tb => tb.HasComment("모델 아이템 정보"));

            entity.HasIndex(e => e.UnitFk, "FK_model_item_index_unit_fk");

            entity.Property(e => e.IndexId)
                .ValueGeneratedNever()
                .HasComment("모델 아이템 ID")
                .HasColumnType("int(11)")
                .HasColumnName("index_id");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("모델 아이템 영문명")
                .HasColumnName("e_name");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("모델 아이템명")
                .HasColumnName("name");
            entity.Property(e => e.UnitFk)
                .HasComment("단위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("unit_fk");

            entity.HasOne(d => d.UnitFkNavigation).WithMany(p => p.ModelItemIndices)
                .HasForeignKey(d => d.UnitFk)
                .HasConstraintName("FK_model_item_index_unit_fk");
        });

        modelBuilder.Entity<MsgErrorType>(entity =>
        {
            entity.HasKey(e => e.MsgErrorTypeId).HasName("PRIMARY");

            entity.ToTable("msg_error_type", tb => tb.HasComment("메시지 결과 에러 코드"));

            entity.Property(e => e.MsgErrorTypeId)
                .ValueGeneratedNever()
                .HasComment("에러 메시지 코드 ID")
                .HasColumnType("int(11)")
                .HasColumnName("msg_error_type_id");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.MsgErrorCode)
                .HasComment("메시지 코드")
                .HasColumnType("int(11)")
                .HasColumnName("msg_error_code");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("에러 코드명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<MsgGroup>(entity =>
        {
            entity.HasKey(e => e.MsgGroupId).HasName("PRIMARY");

            entity.ToTable("msg_group", tb => tb.HasComment("메시지 그룹"));

            entity.Property(e => e.MsgGroupId)
                .ValueGeneratedNever()
                .HasComment("메시지 그룹 ID")
                .HasColumnType("int(11)")
                .HasColumnName("msg_group_id");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("메시지 그룹명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<MsgType>(entity =>
        {
            entity.HasKey(e => e.MsgTypeId).HasName("PRIMARY");

            entity.ToTable("msg_type", tb => tb.HasComment("메시지 타입"));

            entity.HasIndex(e => e.MsgGroupFk, "FK_msg_group_TO_msg_type");

            entity.Property(e => e.MsgTypeId)
                .ValueGeneratedNever()
                .HasComment("메시지 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("msg_type_id");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.MsgCode)
                .HasComment("메시지 타입 코드")
                .HasColumnType("int(11)")
                .HasColumnName("msg_code");
            entity.Property(e => e.MsgGroupFk)
                .HasComment("메시지 그룹")
                .HasColumnType("int(11)")
                .HasColumnName("msg_group_fk");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("메시지 타입명")
                .HasColumnName("name");

            entity.HasOne(d => d.MsgGroupFkNavigation).WithMany(p => p.MsgTypes)
                .HasForeignKey(d => d.MsgGroupFk)
                .HasConstraintName("FK_msg_group_TO_msg_type");
        });

        modelBuilder.Entity<ObjectType>(entity =>
        {
            entity.HasKey(e => e.ObjectTypeId).HasName("PRIMARY");

            entity.ToTable("object_type", tb => tb.HasComment("개체 타입"));

            entity.Property(e => e.ObjectTypeId)
                .ValueGeneratedNever()
                .HasComment("개체 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("object_type_id");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("e_name")
                .HasColumnName("e_name");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("개체 타입명")
                .HasColumnName("name");
            entity.Property(e => e.TypeCode)
                .HasMaxLength(64)
                .HasComment("타입 코드")
                .HasColumnName("type_code");
        });

        modelBuilder.Entity<PointQualityCode>(entity =>
        {
            entity.HasKey(e => e.PointQualityCodeId).HasName("PRIMARY");

            entity.ToTable("point_quality_code", tb => tb.HasComment("포인트 Quality 코드"));

            entity.Property(e => e.PointQualityCodeId)
                .ValueGeneratedNever()
                .HasComment("포인트 Quality 코드 ID")
                .HasColumnType("int(11)")
                .HasColumnName("point_quality_code_id");
            entity.Property(e => e.AliseName)
                .HasMaxLength(8)
                .HasComment("별칭")
                .HasColumnName("alise_name");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("포인트 Quality 코드명")
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasComment("포인트 Quality 코드 값")
                .HasColumnType("smallint(6)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<PointTagCode>(entity =>
        {
            entity.HasKey(e => e.PointTagCodeId).HasName("PRIMARY");

            entity.ToTable("point_tag_code", tb => tb.HasComment("포인트 TAG 코드"));

            entity.Property(e => e.PointTagCodeId)
                .ValueGeneratedNever()
                .HasComment("포인트 TAG 코드 ID")
                .HasColumnType("int(11)")
                .HasColumnName("point_tag_code_id");
            entity.Property(e => e.AliseName)
                .HasMaxLength(8)
                .HasComment("별칭")
                .HasColumnName("alise_name");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("포인트 TAG 코드명")
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasComment("포인트 TAG 코드 값")
                .HasColumnType("smallint(6)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<PointType>(entity =>
        {
            entity.HasKey(e => e.PointTypeId).HasName("PRIMARY");

            entity.ToTable("point_type", tb => tb.HasComment("포인트 타입 정보"));

            entity.Property(e => e.PointTypeId)
                .ValueGeneratedNever()
                .HasComment("포인트 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("point_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("포인트 타입명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PosAlarmCode>(entity =>
        {
            entity.HasKey(e => e.PosAlarmId).HasName("PRIMARY");

            entity.ToTable("pos_alarm_code", tb => tb.HasComment("POS 알람 코드 정보"));

            entity.Property(e => e.PosAlarmId)
                .ValueGeneratedNever()
                .HasComment("알람 코드 ID")
                .HasColumnType("int(11)")
                .HasColumnName("pos_alarm_id");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasComment("알람 코드 영문명")
                .HasColumnName("e_name");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("알람 코드명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PosBsnsCode>(entity =>
        {
            entity.HasKey(e => e.PosBsnsId).HasName("PRIMARY");

            entity.ToTable("pos_bsns_code", tb => tb.HasComment("POS 사업자 코드 정보"));

            entity.Property(e => e.PosBsnsId)
                .ValueGeneratedNever()
                .HasComment("사업 코드 ID")
                .HasColumnType("int(11)")
                .HasColumnName("pos_bsns_id");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("이름")
                .HasColumnName("name");
        });

        modelBuilder.Entity<PosEquipmentLink>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PRIMARY");

            entity.ToTable("pos_equipment_link", tb => tb.HasComment("POS 설비 연결"));

            entity.HasIndex(e => e.CeqFk, "FK_conducting_equipment_TO_pos_equipment_link");

            entity.HasIndex(e => e.PosFk, "FK_pos_system_TO_pos_equipment_link");

            entity.Property(e => e.Idx)
                .ValueGeneratedNever()
                .HasComment("로그인덱스")
                .HasColumnType("bigint(20)")
                .HasColumnName("idx");
            entity.Property(e => e.CeqFk)
                .HasComment("개체 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("ceq_fk");
            entity.Property(e => e.PosFk)
                .HasComment("POSID")
                .HasColumnType("int(11)")
                .HasColumnName("pos_fk");

            entity.HasOne(d => d.CeqFkNavigation).WithMany(p => p.PosEquipmentLinks)
                .HasForeignKey(d => d.CeqFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_conducting_equipment_TO_pos_equipment_link");

            entity.HasOne(d => d.PosFkNavigation).WithMany(p => p.PosEquipmentLinks)
                .HasForeignKey(d => d.PosFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pos_system_TO_pos_equipment_link");
        });

        modelBuilder.Entity<PosSystem>(entity =>
        {
            entity.HasKey(e => e.PosId).HasName("PRIMARY");

            entity.ToTable("pos_system", tb => tb.HasComment("POS 시스템"));

            entity.HasIndex(e => e.StationFk, "FK_substation_TO_pos_system");

            entity.Property(e => e.PosId)
                .ValueGeneratedNever()
                .HasComment("POSID")
                .HasColumnType("int(11)")
                .HasColumnName("pos_id");
            entity.Property(e => e.OdtNo)
                .HasComment("ODT 번호")
                .HasColumnType("int(11)")
                .HasColumnName("odt_no");
            entity.Property(e => e.StationFk)
                .HasComment("스테이션 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("station_fk");

            entity.HasOne(d => d.StationFkNavigation).WithMany(p => p.PosSystems)
                .HasForeignKey(d => d.StationFk)
                .HasConstraintName("FK_substation_TO_pos_system");
        });

        modelBuilder.Entity<ProgramInfo>(entity =>
        {
            entity.HasKey(e => e.ProgramId).HasName("PRIMARY");

            entity.ToTable("program_info", tb => tb.HasComment("프로그램 정보"));

            entity.HasIndex(e => e.AlarmPriorityFk, "FK_alarm_priority_TO_program_info");

            entity.HasIndex(e => e.ComputerFk, "FK_program_info_computer_fk");

            entity.HasIndex(e => e.ProgramTypeFk, "FK_program_info_program_type_fk");

            entity.HasIndex(e => e.StateGroupFk, "FK_state_group_TO_program_info");

            entity.Property(e => e.ProgramId)
                .ValueGeneratedNever()
                .HasComment("프로그램 ID")
                .HasColumnType("int(11)")
                .HasColumnName("program_id");
            entity.Property(e => e.AlarmPriorityFk)
                .HasComment("알람 우선순위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_fk");
            entity.Property(e => e.ComputerFk)
                .HasComment("컴퓨터 ID")
                .HasColumnType("int(11)")
                .HasColumnName("computer_fk");
            entity.Property(e => e.ExecuteType)
                .HasComment("실행타입(0:실행안함, 1:콘솔명령, 2:윈도우 서비스)")
                .HasColumnType("tinyint(4)")
                .HasColumnName("execute_type");
            entity.Property(e => e.IpAddr)
                .HasMaxLength(32)
                .HasComment("IP ADDR")
                .HasColumnName("ip_addr");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("프로그램명")
                .HasColumnName("name");
            entity.Property(e => e.ProcFullName)
                .HasMaxLength(256)
                .HasComment("파일이름(경로포함)")
                .HasColumnName("proc_full_name");
            entity.Property(e => e.ProgramDesc)
                .HasMaxLength(256)
                .HasComment("프로그램 설명(버젼정보)")
                .HasColumnName("program_desc");
            entity.Property(e => e.ProgramNo)
                .HasComment("프로그램번호")
                .HasColumnType("int(11)")
                .HasColumnName("program_no");
            entity.Property(e => e.ProgramTypeFk)
                .HasComment("프로그램 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("program_type_fk");
            entity.Property(e => e.StartCmd)
                .HasMaxLength(256)
                .HasComment("시작 명령")
                .HasColumnName("start_cmd");
            entity.Property(e => e.StateGroupFk)
                .HasComment("상태 그룹 ID")
                .HasColumnType("int(11)")
                .HasColumnName("state_group_fk");
            entity.Property(e => e.StopCmd)
                .HasMaxLength(256)
                .HasComment("종료 명령")
                .HasColumnName("stop_cmd");
            entity.Property(e => e.TcpPort)
                .HasComment("TCP PORT")
                .HasColumnType("int(11)")
                .HasColumnName("tcp_port");
            entity.Property(e => e.UpdatePeriod)
                .HasComment("프로그램 상태 갱신주기")
                .HasColumnType("int(11)")
                .HasColumnName("update_period");
            entity.Property(e => e.UseFlag)
                .HasComment("사용 여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("use_flag");

            entity.HasOne(d => d.AlarmPriorityFkNavigation).WithMany(p => p.ProgramInfos)
                .HasForeignKey(d => d.AlarmPriorityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarm_priority_TO_program_info");

            entity.HasOne(d => d.ComputerFkNavigation).WithMany(p => p.ProgramInfos)
                .HasForeignKey(d => d.ComputerFk)
                .HasConstraintName("FK_program_info_computer_fk");

            entity.HasOne(d => d.ProgramTypeFkNavigation).WithMany(p => p.ProgramInfos)
                .HasForeignKey(d => d.ProgramTypeFk)
                .HasConstraintName("FK_program_info_program_type_fk");

            entity.HasOne(d => d.StateGroupFkNavigation).WithMany(p => p.ProgramInfos)
                .HasForeignKey(d => d.StateGroupFk)
                .HasConstraintName("FK_state_group_TO_program_info");
        });

        modelBuilder.Entity<ProgramState>(entity =>
        {
            entity.HasKey(e => e.ProgramFk).HasName("PRIMARY");

            entity.ToTable("program_state", tb => tb.HasComment("프로그램 상태"));

            entity.Property(e => e.ProgramFk)
                .ValueGeneratedNever()
                .HasComment("프로그램 ID")
                .HasColumnType("int(11)")
                .HasColumnName("program_fk");
            entity.Property(e => e.EndTime)
                .HasComment("종료시간")
                .HasColumnType("timestamp")
                .HasColumnName("end_time");
            entity.Property(e => e.StartTime)
                .HasComment("시작시간")
                .HasColumnType("timestamp")
                .HasColumnName("start_time");
            entity.Property(e => e.Status)
                .HasComment("상태")
                .HasColumnType("tinyint(4)")
                .HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasComment("갱신시간")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");

            entity.HasOne(d => d.ProgramFkNavigation).WithOne(p => p.ProgramState)
                .HasForeignKey<ProgramState>(d => d.ProgramFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_program_state_program_fk");
        });

        modelBuilder.Entity<ProgramType>(entity =>
        {
            entity.HasKey(e => e.ProgramTypeId).HasName("PRIMARY");

            entity.ToTable("program_type", tb => tb.HasComment("프로그램 타입"));

            entity.Property(e => e.ProgramTypeId)
                .ValueGeneratedNever()
                .HasComment("프로그램 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("program_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("타입명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<ProtocolType>(entity =>
        {
            entity.HasKey(e => e.ProtocolTypeId).HasName("PRIMARY");

            entity.ToTable("protocol_type", tb => tb.HasComment("프로토콜 타입"));

            entity.Property(e => e.ProtocolTypeId)
                .ValueGeneratedNever()
                .HasComment("프로토콜 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("protocol_type_id");
            entity.Property(e => e.DefaultDeviceCmd)
                .HasMaxLength(512)
                .HasComment("Default 설비 명령")
                .HasColumnName("default_device_cmd");
            entity.Property(e => e.DefaultParameter)
                .HasMaxLength(512)
                .HasComment("Default 파라메타")
                .HasColumnName("default_parameter");
            entity.Property(e => e.DllDescription)
                .HasMaxLength(256)
                .HasComment("DLL 설명")
                .HasColumnName("dll_description");
            entity.Property(e => e.DllFile)
                .HasComment("DLL 파일")
                .HasColumnType("mediumblob")
                .HasColumnName("dll_file");
            entity.Property(e => e.DllName)
                .HasMaxLength(64)
                .HasComment("DLL 이름")
                .HasColumnName("dll_name");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("프로토콜 타입명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<RemoteControlValue>(entity =>
        {
            entity.HasKey(e => e.RemoteControlId).HasName("PRIMARY");

            entity.ToTable("remote_control_value", tb => tb.HasComment("원격 제어 설정 정보"));

            entity.Property(e => e.RemoteControlId)
                .ValueGeneratedNever()
                .HasComment("원격 제어 ID")
                .HasColumnType("int(11)")
                .HasColumnName("remote_control_id");
            entity.Property(e => e.ControlValue)
                .HasComment("원격 제어 값")
                .HasColumnType("int(11)")
                .HasColumnName("control_value");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("원격 제어 명")
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasComment("HMI 제어 값")
                .HasColumnType("int(11)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PRIMARY");

            entity.ToTable("report", tb => tb.HasComment("레포트"));

            entity.HasIndex(e => e.FormFk, "FK_report_form_fk");

            entity.Property(e => e.ReportId)
                .ValueGeneratedNever()
                .HasComment("레포트 ID")
                .HasColumnType("int(11)")
                .HasColumnName("report_id");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("생성 시간")
                .HasColumnType("timestamp")
                .HasColumnName("create_time");
            entity.Property(e => e.ExtractionDate)
                .HasMaxLength(16)
                .HasComment("데이터추출일")
                .HasColumnName("extraction_date");
            entity.Property(e => e.FileName)
                .HasMaxLength(128)
                .HasComment("파일 이름")
                .HasColumnName("file_name");
            entity.Property(e => e.FormFk)
                .HasComment("레포트 폼 ID")
                .HasColumnType("int(11)")
                .HasColumnName("form_fk");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("레포트명")
                .HasColumnName("name");
            entity.Property(e => e.ReportExcelFile)
                .HasComment("레포트 엑셀 파일")
                .HasColumnType("mediumblob")
                .HasColumnName("report_excel_file");
            entity.Property(e => e.ReportPdfFile)
                .HasComment("레포트 PDF 파일")
                .HasColumnType("mediumblob")
                .HasColumnName("report_pdf_file");

            entity.HasOne(d => d.FormFkNavigation).WithMany(p => p.Reports)
                .HasForeignKey(d => d.FormFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_report_form_fk");
        });

        modelBuilder.Entity<ReportForm>(entity =>
        {
            entity.HasKey(e => e.FormId).HasName("PRIMARY");

            entity.ToTable("report_form", tb => tb.HasComment("레포트 폼"));

            entity.HasIndex(e => e.FormTypeFk, "FK_report_form_form_type_fk");

            entity.Property(e => e.FormId)
                .ValueGeneratedNever()
                .HasComment("레포트 폼 ID")
                .HasColumnType("int(11)")
                .HasColumnName("form_id");
            entity.Property(e => e.AutoCreation)
                .HasComment("자동보고서 생성여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("auto_creation");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("생성 시간")
                .HasColumnType("timestamp")
                .HasColumnName("create_time");
            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .HasComment("설명")
                .HasColumnName("description");
            entity.Property(e => e.FileName)
                .HasMaxLength(128)
                .HasComment("파일 이름")
                .HasColumnName("file_name");
            entity.Property(e => e.FormFile)
                .HasComment("레포트 폼 파일")
                .HasColumnType("mediumblob")
                .HasColumnName("form_file");
            entity.Property(e => e.FormTypeFk)
                .HasComment("레포트 폼 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("form_type_fk");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("레포트 폼명")
                .HasColumnName("name");

            entity.HasOne(d => d.FormTypeFkNavigation).WithMany(p => p.ReportForms)
                .HasForeignKey(d => d.FormTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_report_form_form_type_fk");
        });

        modelBuilder.Entity<ReportFormType>(entity =>
        {
            entity.HasKey(e => e.FormTypeId).HasName("PRIMARY");

            entity.ToTable("report_form_type", tb => tb.HasComment("레포트 폼 타입"));

            entity.Property(e => e.FormTypeId)
                .ValueGeneratedNever()
                .HasComment("레포트 폼 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("form_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("레포트 폼 타입명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<ReportOperatorType>(entity =>
        {
            entity.HasKey(e => e.OperatorTypeId).HasName("PRIMARY");

            entity.ToTable("report_operator_type", tb => tb.HasComment("레포트 연산자 타입"));

            entity.Property(e => e.OperatorTypeId)
                .ValueGeneratedNever()
                .HasComment("레포트 연산자 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("operator_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("레포트 연산자 타입명")
                .HasColumnName("name");
            entity.Property(e => e.OperatorCode)
                .HasMaxLength(32)
                .HasComment("레포트 연산자 타입 코드")
                .HasColumnName("operator_code");
        });

        modelBuilder.Entity<ScaleFactor>(entity =>
        {
            entity.HasKey(e => e.ScaleFactorId).HasName("PRIMARY");

            entity.ToTable("scale_factor", tb => tb.HasComment("스케일 펙터"));

            entity.Property(e => e.ScaleFactorId)
                .ValueGeneratedNever()
                .HasComment("스케일 펙터 ID")
                .HasColumnType("int(11)")
                .HasColumnName("scale_factor_id");
            entity.Property(e => e.Offset)
                .HasComment("스케일 펙터 OFFSET 값")
                .HasColumnName("offset");
            entity.Property(e => e.Scale)
                .HasDefaultValueSql("'1'")
                .HasComment("스케일 펙터 값")
                .HasColumnName("scale");
        });

        modelBuilder.Entity<SnmpGroup>(entity =>
        {
            entity.HasKey(e => e.SnmpGroupId).HasName("PRIMARY");

            entity.ToTable("snmp_group", tb => tb.HasComment("SNMP 그룹"));

            entity.Property(e => e.SnmpGroupId)
                .ValueGeneratedNever()
                .HasComment("snmp 그룹 아이디")
                .HasColumnType("int(11)")
                .HasColumnName("snmp_group_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("snmp 그룹 이름")
                .HasColumnName("name");
        });

        modelBuilder.Entity<SnmpInfo>(entity =>
        {
            entity.HasKey(e => e.SnmpId).HasName("PRIMARY");

            entity.ToTable("snmp_info", tb => tb.HasComment("SNMP 정보"));

            entity.HasIndex(e => e.AlarmPriorityFk, "FK_alarm_priority_TO_snmp_info");

            entity.HasIndex(e => e.MemberOfficeFk, "FK_member_office_TO_snmp_info");

            entity.HasIndex(e => e.SnmpGroupFk, "FK_snmp_group_TO_snmp_info");

            entity.HasIndex(e => e.OsTypeFk, "FK_snmp_os_type_TO_snmp_info");

            entity.HasIndex(e => e.StateGorupFk, "FK_state_group_TO_snmp_info");

            entity.Property(e => e.SnmpId)
                .ValueGeneratedNever()
                .HasComment("아이디")
                .HasColumnType("int(11)")
                .HasColumnName("snmp_id");
            entity.Property(e => e.Address)
                .HasMaxLength(32)
                .HasComment("주소")
                .HasColumnName("address");
            entity.Property(e => e.AlarmPriorityFk)
                .HasComment("알람 우선순위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_fk");
            entity.Property(e => e.CommunityName)
                .HasMaxLength(32)
                .HasComment("커뮤니티 이름")
                .HasColumnName("community_name");
            entity.Property(e => e.DeviceName)
                .HasMaxLength(64)
                .HasComment("장비 이름")
                .HasColumnName("device_name");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.OsTypeFk)
                .HasComment("OS 타입")
                .HasColumnType("int(11)")
                .HasColumnName("os_type_fk");
            entity.Property(e => e.Port)
                .HasComment("포트")
                .HasColumnType("int(11)")
                .HasColumnName("port");
            entity.Property(e => e.SnmpGroupFk)
                .HasComment("snmp 그룹 아이디")
                .HasColumnType("int(11)")
                .HasColumnName("snmp_group_fk");
            entity.Property(e => e.StateGorupFk)
                .HasComment("상태 그룹 코드")
                .HasColumnType("int(11)")
                .HasColumnName("state_gorup_fk");
            entity.Property(e => e.TimeOut)
                .HasComment("타임아웃")
                .HasColumnType("int(11)")
                .HasColumnName("time_out");

            entity.HasOne(d => d.AlarmPriorityFkNavigation).WithMany(p => p.SnmpInfos)
                .HasForeignKey(d => d.AlarmPriorityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alarm_priority_TO_snmp_info");

            entity.HasOne(d => d.MemberOfficeFkNavigation).WithMany(p => p.SnmpInfos)
                .HasForeignKey(d => d.MemberOfficeFk)
                .HasConstraintName("FK_member_office_TO_snmp_info");

            entity.HasOne(d => d.OsTypeFkNavigation).WithMany(p => p.SnmpInfos)
                .HasForeignKey(d => d.OsTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_snmp_os_type_TO_snmp_info");

            entity.HasOne(d => d.SnmpGroupFkNavigation).WithMany(p => p.SnmpInfos)
                .HasForeignKey(d => d.SnmpGroupFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_snmp_group_TO_snmp_info");

            entity.HasOne(d => d.StateGorupFkNavigation).WithMany(p => p.SnmpInfos)
                .HasForeignKey(d => d.StateGorupFk)
                .HasConstraintName("FK_state_group_TO_snmp_info");
        });

        modelBuilder.Entity<SnmpOidInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("snmp_oid_info", tb => tb.HasComment("OID 정보"));

            entity.HasIndex(e => e.OsType, "FK_snmp_os_type_TO_snmp_oid_info");

            entity.Property(e => e.OidDesc)
                .HasMaxLength(32)
                .HasComment("OID 설명")
                .HasColumnName("oid_desc");
            entity.Property(e => e.OidId)
                .HasComment("OID 아이디")
                .HasColumnType("int(11)")
                .HasColumnName("oid_id");
            entity.Property(e => e.OidIndex)
                .HasComment("OID 인덱스")
                .HasColumnType("int(11)")
                .HasColumnName("oid_index");
            entity.Property(e => e.OidValue)
                .HasMaxLength(64)
                .HasComment("OID 정보")
                .HasColumnName("oid_value");
            entity.Property(e => e.OsType)
                .HasComment("OS 타입")
                .HasColumnType("int(11)")
                .HasColumnName("os_type");

            entity.HasOne(d => d.OsTypeNavigation).WithMany()
                .HasForeignKey(d => d.OsType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_snmp_os_type_TO_snmp_oid_info");
        });

        modelBuilder.Entity<SnmpOsType>(entity =>
        {
            entity.HasKey(e => e.OsType).HasName("PRIMARY");

            entity.ToTable("snmp_os_type", tb => tb.HasComment("운영체제 타입"));

            entity.Property(e => e.OsType)
                .ValueGeneratedNever()
                .HasComment("OS 타입")
                .HasColumnType("int(11)")
                .HasColumnName("os_type");
            entity.Property(e => e.OsName)
                .HasMaxLength(32)
                .HasComment("OS 이름")
                .HasColumnName("os_name");
        });

        modelBuilder.Entity<SnmpState>(entity =>
        {
            entity.HasKey(e => e.SnmpFk).HasName("PRIMARY");

            entity.ToTable("snmp_state", tb => tb.HasComment("SNMP 상태"));

            entity.Property(e => e.SnmpFk)
                .ValueGeneratedNever()
                .HasComment("SNMP ID")
                .HasColumnType("int(11)")
                .HasColumnName("snmp_fk");
            entity.Property(e => e.CpuRate)
                .HasComment("CPU 사용률(%)")
                .HasColumnName("cpu_rate");
            entity.Property(e => e.DiskRate)
                .HasComment("DISK 사용률(%)")
                .HasColumnName("disk_rate");
            entity.Property(e => e.MemRate)
                .HasComment("MEM 사용률(%)")
                .HasColumnName("mem_rate");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.PortId)
                .HasMaxLength(512)
                .HasComment("포트 아이디")
                .HasColumnName("port_id");
            entity.Property(e => e.PortValue)
                .HasMaxLength(512)
                .HasComment("포트 값")
                .HasColumnName("port_value");
            entity.Property(e => e.Status)
                .HasComment("상태")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasComment("갱신 시간")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");

            entity.HasOne(d => d.SnmpFkNavigation).WithOne(p => p.SnmpState)
                .HasForeignKey<SnmpState>(d => d.SnmpFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_snmp_info_TO_snmp_state");
        });

        modelBuilder.Entity<Sound>(entity =>
        {
            entity.HasKey(e => e.SoundId).HasName("PRIMARY");

            entity.ToTable("sound", tb => tb.HasComment("소리"));

            entity.Property(e => e.SoundId)
                .ValueGeneratedNever()
                .HasComment("소리 ID")
                .HasColumnType("int(11)")
                .HasColumnName("sound_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("소리 이름")
                .HasColumnName("name");
            entity.Property(e => e.SoundFile)
                .HasComment("소리 파일")
                .HasColumnType("mediumblob")
                .HasColumnName("sound_file");
        });

        modelBuilder.Entity<StateGroup>(entity =>
        {
            entity.HasKey(e => e.StateGroupId).HasName("PRIMARY");

            entity.ToTable("state_group", tb => tb.HasComment("상태 그룹 정보"));

            entity.Property(e => e.StateGroupId)
                .ValueGeneratedNever()
                .HasComment("상태 그룹 ID")
                .HasColumnType("int(11)")
                .HasColumnName("state_group_id");
            entity.Property(e => e.Count)
                .HasComment("상태 개수")
                .HasColumnType("int(11)")
                .HasColumnName("count");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("상태 그룹명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<StateValue>(entity =>
        {
            entity.HasKey(e => e.StateValueId).HasName("PRIMARY");

            entity.ToTable("state_value", tb => tb.HasComment("상태 값 변경이름정보"));

            entity.HasIndex(e => e.StateGroupFk, "FK_state_value_state_group_fk");

            entity.Property(e => e.StateValueId)
                .ValueGeneratedNever()
                .HasComment("상태값 변경 ID")
                .HasColumnType("int(11)")
                .HasColumnName("state_value_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("상태값 변경명")
                .HasColumnName("name");
            entity.Property(e => e.StateGroupFk)
                .HasComment("상태 그룹 ID")
                .HasColumnType("int(11)")
                .HasColumnName("state_group_fk");
            entity.Property(e => e.Value)
                .HasComment("상태값")
                .HasColumnName("value");

            entity.HasOne(d => d.StateGroupFkNavigation).WithMany(p => p.StateValues)
                .HasForeignKey(d => d.StateGroupFk)
                .HasConstraintName("FK_state_value_state_group_fk");
        });

        modelBuilder.Entity<StationType>(entity =>
        {
            entity.HasKey(e => e.StationTypeId).HasName("PRIMARY");

            entity.ToTable("station_type", tb => tb.HasComment("스테이션(변전소) 타입"));

            entity.Property(e => e.StationTypeId)
                .ValueGeneratedNever()
                .HasComment("스테이션 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("station_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("스테이션명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Substation>(entity =>
        {
            entity.HasKey(e => e.StationMrfk).HasName("PRIMARY");

            entity.ToTable("substation", tb => tb.HasComment("스테이션 정보"));

            entity.HasIndex(e => e.MemberOfficeFk, "FK_substation_member_office_fk");

            entity.HasIndex(e => e.StationTypeFk, "FK_substation_station_type_fk");

            entity.Property(e => e.StationMrfk)
                .ValueGeneratedNever()
                .HasComment("스테이션 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("station_mrfk");
            entity.Property(e => e.BsensCode)
                .HasMaxLength(16)
                .HasComment("사업자코드")
                .HasColumnName("bsens_code");
            entity.Property(e => e.InstallDate)
                .HasMaxLength(16)
                .HasComment("설치일자")
                .HasColumnName("install_date");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(16)
                .HasComment("전화번호")
                .HasColumnName("phone_no");
            entity.Property(e => e.StationAdder)
                .HasMaxLength(256)
                .HasComment("스테이션 주소")
                .HasColumnName("station_adder");
            entity.Property(e => e.StationCode)
                .HasMaxLength(8)
                .HasComment("스테이션 코드")
                .HasColumnName("station_code");
            entity.Property(e => e.StationTypeFk)
                .HasComment("스테이션 타입")
                .HasColumnType("int(11)")
                .HasColumnName("station_type_fk");

            entity.HasOne(d => d.MemberOfficeFkNavigation).WithMany(p => p.Substations)
                .HasForeignKey(d => d.MemberOfficeFk)
                .HasConstraintName("FK_substation_member_office_fk");

            entity.HasOne(d => d.StationTypeFkNavigation).WithMany(p => p.Substations)
                .HasForeignKey(d => d.StationTypeFk)
                .HasConstraintName("FK_substation_station_type_fk");
        });

        modelBuilder.Entity<SystemSetting>(entity =>
        {
            entity.HasKey(e => e.Idx).HasName("PRIMARY");

            entity.ToTable("system_setting", tb => tb.HasComment("시스템 설정 테이블"));

            entity.HasIndex(e => e.SetKey, "unique_system_setting_set_key").IsUnique();

            entity.Property(e => e.Idx)
                .HasComment("아이디")
                .HasColumnType("bigint(20)")
                .HasColumnName("idx");
            entity.Property(e => e.SetKey)
                .HasMaxLength(64)
                .HasComment("설정키")
                .HasColumnName("set_key");
            entity.Property(e => e.SetValue)
                .HasMaxLength(128)
                .HasComment("설정값")
                .HasColumnName("set_value");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.UnitId).HasName("PRIMARY");

            entity.ToTable("unit", tb => tb.HasComment("단위"));

            entity.Property(e => e.UnitId)
                .ValueGeneratedNever()
                .HasComment("단위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("unit_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("단위")
                .HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("user", tb => tb.HasComment("사용자 정보"));

            entity.HasIndex(e => e.UserAuthorityTypeFk, "FK_user_authority_type_TO_user");

            entity.HasIndex(e => e.MemberOfficeFk, "FK_user_member_office_fk");

            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasComment("사용자 ID")
                .HasColumnName("user_id");
            entity.Property(e => e.DeleteFlag)
                .HasComment("삭제 여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("delete_flag");
            entity.Property(e => e.Email)
                .HasMaxLength(64)
                .HasComment("이메일")
                .HasColumnName("email");
            entity.Property(e => e.IsNotify)
                .HasDefaultValueSql("'0'")
                .HasComment("알림여부:0,1")
                .HasColumnType("tinyint(4)")
                .HasColumnName("is_notify");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(32)
                .HasComment("전화번호")
                .HasColumnName("mobile_no");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("사용자명")
                .HasColumnName("name");
            entity.Property(e => e.Organization)
                .HasMaxLength(32)
                .HasComment("조직정보")
                .HasColumnName("organization");
            entity.Property(e => e.Password)
                .HasMaxLength(256)
                .HasComment("패스워드")
                .HasColumnName("password");
            entity.Property(e => e.UserAuthorityTypeFk)
                .HasComment("사용자 권한 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("user_authority_type_fk");

            entity.HasOne(d => d.MemberOfficeFkNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.MemberOfficeFk)
                .HasConstraintName("FK_user_member_office_fk");

            entity.HasOne(d => d.UserAuthorityTypeFkNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserAuthorityTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_authority_type_TO_user");
        });

        modelBuilder.Entity<UserAuthorityType>(entity =>
        {
            entity.HasKey(e => e.UserAuthorityTypeId).HasName("PRIMARY");

            entity.ToTable("user_authority_type", tb => tb.HasComment("사용자 권한 타입"));

            entity.Property(e => e.UserAuthorityTypeId)
                .ValueGeneratedNever()
                .HasComment("사용자 권한 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("user_authority_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("사용자 권한 타입명")
                .HasColumnName("name");
        });

        modelBuilder.Entity<VBusDetailInfoView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_bus_detail_info_view");

            entity.Property(e => e.AfterFuelAmount)
                .HasComment("연료충전완료후량")
                .HasColumnType("int(11)")
                .HasColumnName("after_fuel_amount");
            entity.Property(e => e.AfterFuelMileage)
                .HasColumnType("bigint(21)")
                .HasColumnName("after_fuel_mileage");
            entity.Property(e => e.AfterFuelUsage).HasColumnName("after_fuel_usage");
            entity.Property(e => e.BeforeFuelMileage)
                .HasComment("연료주입시총주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("before_fuel_mileage");
            entity.Property(e => e.BeforeSeq)
                .HasComment("정류장순번")
                .HasColumnType("int(11)")
                .HasColumnName("before_seq");
            entity.Property(e => e.BeforeStopId)
                .HasComment("이전 정류장 위치")
                .HasColumnType("bigint(20)")
                .HasColumnName("before_stop_id");
            entity.Property(e => e.BeforeStopName)
                .HasMaxLength(64)
                .HasComment("이름")
                .HasColumnName("before_stop_name");
            entity.Property(e => e.BrtClass)
                .HasComment("노선번호확장")
                .HasColumnType("tinyint(4)")
                .HasColumnName("brt_class");
            entity.Property(e => e.BrtId)
                .HasComment("노선번호")
                .HasColumnType("int(11)")
                .HasColumnName("brt_id");
            entity.Property(e => e.BrtStdId)
                .HasComment("노선 식별 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("brt_std_id");
            entity.Property(e => e.BusLow)
                .HasComment("저상여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("bus_low");
            entity.Property(e => e.BusNo)
                .HasComment("버스 번호")
                .HasColumnType("int(11)")
                .HasColumnName("bus_no");
            entity.Property(e => e.FuelInjectionDate)
                .HasComment("연료주입일")
                .HasColumnType("timestamp")
                .HasColumnName("fuel_injection_date");
            entity.Property(e => e.FuelRemainAmount).HasColumnName("fuel_remain_amount");
            entity.Property(e => e.MaxBrsSeqno)
                .HasComment("정류장순번")
                .HasColumnType("int(11)")
                .HasColumnName("max_brs_seqno");
            entity.Property(e => e.NextSeq)
                .HasComment("정류장순번")
                .HasColumnType("int(11)")
                .HasColumnName("next_seq");
            entity.Property(e => e.NextStopName)
                .HasMaxLength(64)
                .HasComment("이름")
                .HasColumnName("next_stop_name");
            entity.Property(e => e.NextStopStdId)
                .HasComment("정류장 표준ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("next_stop_std_id");
            entity.Property(e => e.NowSeq)
                .HasComment("정류장순번")
                .HasColumnType("int(11)")
                .HasColumnName("now_seq");
            entity.Property(e => e.NowStopId)
                .HasComment("현재 정류장 위치")
                .HasColumnType("bigint(20)")
                .HasColumnName("now_stop_id");
            entity.Property(e => e.NowStopName)
                .HasMaxLength(64)
                .HasComment("이름")
                .HasColumnName("now_stop_name");
            entity.Property(e => e.NowStopx)
                .HasComment("x좌표(경도)")
                .HasColumnName("now_stopx");
            entity.Property(e => e.NowStopy)
                .HasComment("y좌표(위도)")
                .HasColumnName("now_stopy");
            entity.Property(e => e.StopCnt)
                .HasColumnType("bigint(21)")
                .HasColumnName("stop_cnt");
            entity.Property(e => e.TodayMileage)
                .HasComment("일일주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("today_mileage");
            entity.Property(e => e.TotalMileage)
                .HasComment("전체주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("total_mileage");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<VBusRouteStopView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_bus_route_stop_view");

            entity.Property(e => e.BrsSeqno)
                .HasComment("정류장순번")
                .HasColumnType("int(11)")
                .HasColumnName("brs_seqno");
            entity.Property(e => e.BrtStdId)
                .HasComment("노선 식별 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("brt_std_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("이름")
                .HasColumnName("name");
            entity.Property(e => e.StopStandardId)
                .HasComment("정류장 표준ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("stop_standard_id");
            entity.Property(e => e.Stopx)
                .HasComment("x좌표(경도)")
                .HasColumnName("stopx");
            entity.Property(e => e.Stopy)
                .HasComment("y좌표(위도)")
                .HasColumnName("stopy");
        });

        modelBuilder.Entity<VBusTagoDetailInfoView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_bus_tago_detail_info_view");

            entity.Property(e => e.AfterFuelAmount)
                .HasComment("연료충전완료후량")
                .HasColumnType("int(11)")
                .HasColumnName("after_fuel_amount");
            entity.Property(e => e.AfterFuelMileage)
                .HasColumnType("bigint(21)")
                .HasColumnName("after_fuel_mileage");
            entity.Property(e => e.AfterFuelUsage).HasColumnName("after_fuel_usage");
            entity.Property(e => e.BeforeNodeId)
                .HasMaxLength(16)
                .HasComment("정류장ID")
                .HasColumnName("before_node_id");
            entity.Property(e => e.BeforeNodeName)
                .HasMaxLength(64)
                .HasComment("정류장이름")
                .HasColumnName("before_node_name");
            entity.Property(e => e.BeforeNodeOrder)
                .HasComment("노드순서")
                .HasColumnType("int(11)")
                .HasColumnName("before_node_order");
            entity.Property(e => e.CityCode)
                .HasComment("도시코드")
                .HasColumnType("int(11)")
                .HasColumnName("city_code");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("생성시간")
                .HasColumnType("timestamp")
                .HasColumnName("create_time");
            entity.Property(e => e.EndNodeName)
                .HasMaxLength(32)
                .HasComment("종점")
                .HasColumnName("end_node_name");
            entity.Property(e => e.EndVehicleTime)
                .HasMaxLength(8)
                .HasComment("막차시간")
                .HasColumnName("end_vehicle_time");
            entity.Property(e => e.FuelInjectionDate)
                .HasComment("연료주입일")
                .HasColumnType("timestamp")
                .HasColumnName("fuel_injection_date");
            entity.Property(e => e.FuelInjectionMileage)
                .HasComment("연료주입시총주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("fuel_injection_mileage");
            entity.Property(e => e.FuelRemainAmount).HasColumnName("fuel_remain_amount");
            entity.Property(e => e.GpsLati)
                .HasComment("위도")
                .HasColumnName("gps_lati");
            entity.Property(e => e.GpsLong)
                .HasComment("경도")
                .HasColumnName("gps_long");
            entity.Property(e => e.MemberOfficeId)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_id");
            entity.Property(e => e.NextNodeId)
                .HasMaxLength(16)
                .HasComment("정류장ID")
                .HasColumnName("next_node_id");
            entity.Property(e => e.NextNodeName)
                .HasMaxLength(64)
                .HasComment("정류장이름")
                .HasColumnName("next_node_name");
            entity.Property(e => e.NextNodeOrder)
                .HasComment("노드순서")
                .HasColumnType("int(11)")
                .HasColumnName("next_node_order");
            entity.Property(e => e.NodeId)
                .HasMaxLength(16)
                .HasComment("정류장ID")
                .HasColumnName("node_id");
            entity.Property(e => e.NodeName)
                .HasMaxLength(64)
                .HasComment("정류장이름")
                .HasColumnName("node_name");
            entity.Property(e => e.NodeOrder)
                .HasComment("노드순서")
                .HasColumnType("int(11)")
                .HasColumnName("node_order");
            entity.Property(e => e.RouteId)
                .HasMaxLength(16)
                .HasComment("노선ID")
                .HasColumnName("route_id");
            entity.Property(e => e.RouteNo)
                .HasMaxLength(16)
                .HasComment("노선번호")
                .HasColumnName("route_no");
            entity.Property(e => e.RouteTp)
                .HasMaxLength(16)
                .HasComment("노선유형")
                .HasColumnName("route_tp");
            entity.Property(e => e.StartNodeName)
                .HasMaxLength(32)
                .HasComment("기점")
                .HasColumnName("start_node_name");
            entity.Property(e => e.StartVehicleTime)
                .HasMaxLength(8)
                .HasComment("첫차시간")
                .HasColumnName("start_vehicle_time");
            entity.Property(e => e.TodayMileage)
                .HasComment("일일주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("today_mileage");
            entity.Property(e => e.TotalMileage)
                .HasComment("전체주행거리")
                .HasColumnType("bigint(20)")
                .HasColumnName("total_mileage");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasComment("업데이트 시간(저장시간)")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
            entity.Property(e => e.VehicleNo)
                .HasComment("차량번호")
                .HasColumnType("int(11)")
                .HasColumnName("vehicle_no");
        });

        modelBuilder.Entity<VCeqPointIndexView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ceq_point_index_view");

            entity.Property(e => e.AlarmPriority)
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority");
            entity.Property(e => e.AlarmTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("alarm_type_id");
            entity.Property(e => e.CeqTypeEname)
                .HasMaxLength(64)
                .HasComment("설비 영문 타입명")
                .HasColumnName("ceq_type_ename");
            entity.Property(e => e.CeqTypeGroupId)
                .HasComment("ceq_type_group_fk")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_group_id");
            entity.Property(e => e.CeqTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_id");
            entity.Property(e => e.CeqTypeName)
                .HasMaxLength(64)
                .HasComment("설비 타입명")
                .HasColumnName("ceq_type_name");
            entity.Property(e => e.DataTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("data_type_id");
            entity.Property(e => e.DtStr)
                .HasMaxLength(6)
                .HasColumnName("dt_str");
            entity.Property(e => e.DynamicIndex)
                .HasColumnType("bigint(20)")
                .HasColumnName("dynamic_index");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("e_name");
            entity.Property(e => e.LimitMaxValue).HasColumnName("limit_max_value");
            entity.Property(e => e.LimitMinValue).HasColumnName("limit_min_value");
            entity.Property(e => e.ModelId)
                .HasComment("모델 ID")
                .HasColumnType("int(11)")
                .HasColumnName("model_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.PointTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("point_type_id");
            entity.Property(e => e.StateGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("state_group_id");
            entity.Property(e => e.UnitId)
                .HasColumnType("int(11)")
                .HasColumnName("unit_id");
            entity.Property(e => e.UnitName)
                .HasMaxLength(64)
                .HasComment("단위")
                .HasColumnName("unit_name");
        });

        modelBuilder.Entity<VComputerInfoView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_computer_info_view");

            entity.Property(e => e.AlarmPriorityFk)
                .HasComment("알람 우선순위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_fk");
            entity.Property(e => e.ComputerGroupFk)
                .HasComment("컴퓨터 그룹ID")
                .HasColumnType("int(11)")
                .HasColumnName("computer_group_fk");
            entity.Property(e => e.ComputerId)
                .HasComment("컴퓨터 ID")
                .HasColumnType("int(11)")
                .HasColumnName("computer_id");
            entity.Property(e => e.DpName)
                .HasMaxLength(23)
                .HasColumnName("dp_name");
            entity.Property(e => e.DpType)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("dp_type");
            entity.Property(e => e.GroupName)
                .HasMaxLength(64)
                .HasComment("컴퓨터 그룹명")
                .HasColumnName("group_name");
            entity.Property(e => e.IsDup)
                .HasComment("이중화구성여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("is_dup");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("컴퓨터명")
                .HasColumnName("name");
            entity.Property(e => e.OsName)
                .HasMaxLength(64)
                .HasComment("OS 이름")
                .HasColumnName("os_name");
            entity.Property(e => e.OsVersion)
                .HasMaxLength(64)
                .HasComment("OS 버젼")
                .HasColumnName("os_version");
            entity.Property(e => e.StateGroupFk)
                .HasComment("상태 그룹 ID")
                .HasColumnType("int(11)")
                .HasColumnName("state_group_fk");
            entity.Property(e => e.UseFlag)
                .HasComment("사용 여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("use_flag");
        });

        modelBuilder.Entity<VConductingEquipmentView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_conducting_equipment_view");

            entity.Property(e => e.CeqAliasName)
                .HasMaxLength(64)
                .HasComment("별칭")
                .HasColumnName("ceq_alias_name");
            entity.Property(e => e.CeqId)
                .HasComment("개체 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("ceq_id");
            entity.Property(e => e.CeqName)
                .HasMaxLength(64)
                .HasComment("개체명")
                .HasColumnName("ceq_name");
            entity.Property(e => e.CeqTypeFk)
                .HasComment("설비 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_fk");
            entity.Property(e => e.CeqTypeGroupId)
                .HasComment("ceq_type_group_fk")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_group_id");
            entity.Property(e => e.CircuitNo)
                .HasComment("회로번호")
                .HasColumnType("tinyint(4)")
                .HasColumnName("circuit_no");
            entity.Property(e => e.DeviceFk)
                .HasComment("통신기기ID")
                .HasColumnType("int(11)")
                .HasColumnName("device_fk");
            entity.Property(e => e.DpName)
                .HasMaxLength(169)
                .HasColumnName("dp_name");
            entity.Property(e => e.DpType)
                .HasMaxLength(64)
                .HasComment("설비 영문 타입명")
                .HasColumnName("dp_type");
            entity.Property(e => e.ModelId)
                .HasComment("연결 모델 ID")
                .HasColumnType("int(11)")
                .HasColumnName("model_id");
            entity.Property(e => e.ModelName)
                .HasMaxLength(64)
                .HasComment("모델명")
                .HasColumnName("model_name");
            entity.Property(e => e.ObjectType)
                .HasComment("개체 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("object_type");
            entity.Property(e => e.ObjectTypeEname)
                .HasMaxLength(64)
                .HasComment("e_name")
                .HasColumnName("object_type_ename");
            entity.Property(e => e.ObjectTypeName)
                .HasMaxLength(64)
                .HasComment("개체 타입명")
                .HasColumnName("object_type_name");
            entity.Property(e => e.OfficeCode)
                .HasComment("지역 코드 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("office_code");
            entity.Property(e => e.StationMrfk)
                .HasComment("소속 스테이션 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("station_mrfk");
            entity.Property(e => e.StationName)
                .HasMaxLength(64)
                .HasComment("개체명")
                .HasColumnName("station_name");
            entity.Property(e => e.StnTypeCode)
                .HasMaxLength(64)
                .HasComment("타입 코드")
                .HasColumnName("stn_type_code");
            entity.Property(e => e.TypeCode)
                .HasMaxLength(64)
                .HasComment("타입 코드")
                .HasColumnName("type_code");
        });

        modelBuilder.Entity<VDevicePointIndexView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_device_point_index_view");

            entity.Property(e => e.AlarmPriority)
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority");
            entity.Property(e => e.AlarmTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("alarm_type_id");
            entity.Property(e => e.BitPosition)
                .HasColumnType("int(4)")
                .HasColumnName("bit_position");
            entity.Property(e => e.CeqTypeGroupId)
                .HasComment("ceq_type_group_fk")
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_group_id");
            entity.Property(e => e.CeqTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("ceq_type_id");
            entity.Property(e => e.CeqTypeName)
                .HasMaxLength(64)
                .HasComment("설비 타입명")
                .HasColumnName("ceq_type_name");
            entity.Property(e => e.CircuitNo)
                .HasColumnType("int(11)")
                .HasColumnName("circuit_no");
            entity.Property(e => e.ClassNo)
                .HasColumnType("int(11)")
                .HasColumnName("class_no");
            entity.Property(e => e.DataTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("data_type_id");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasColumnName("description");
            entity.Property(e => e.DynamicIndex)
                .HasColumnType("bigint(20)")
                .HasColumnName("dynamic_index");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasColumnName("e_name");
            entity.Property(e => e.LimitMaxValue).HasColumnName("limit_max_value");
            entity.Property(e => e.LimitMinValue).HasColumnName("limit_min_value");
            entity.Property(e => e.ModbusAddress)
                .HasColumnType("int(11)")
                .HasColumnName("modbus_address");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Offset)
                .HasComment("스케일 펙터 OFFSET 값")
                .HasColumnName("offset");
            entity.Property(e => e.PointIndex)
                .HasColumnType("int(11)")
                .HasColumnName("point_index");
            entity.Property(e => e.PointTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("point_type_id");
            entity.Property(e => e.RemoteAddress)
                .HasMaxLength(11)
                .HasColumnName("remote_address");
            entity.Property(e => e.Scale)
                .HasDefaultValueSql("'1'")
                .HasComment("스케일 펙터 값")
                .HasColumnName("scale");
            entity.Property(e => e.StateGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("state_group_id");
            entity.Property(e => e.UnitId)
                .HasColumnType("int(11)")
                .HasColumnName("unit_id");
            entity.Property(e => e.UnitName)
                .HasMaxLength(64)
                .HasComment("단위")
                .HasColumnName("unit_name");
        });

        modelBuilder.Entity<VPointIndexView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_point_index_view");

            entity.Property(e => e.AlarmPriorityId)
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_id");
            entity.Property(e => e.AlarmTypeFk)
                .HasColumnType("int(11)")
                .HasColumnName("alarm_type_fk");
            entity.Property(e => e.DataTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("data_type_id");
            entity.Property(e => e.DynamicIndex)
                .HasColumnType("bigint(16)")
                .HasColumnName("dynamic_index");
            entity.Property(e => e.EName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("e_name");
            entity.Property(e => e.LimitMaxValue).HasColumnName("limit_max_value");
            entity.Property(e => e.LimitMinValue).HasColumnName("limit_min_value");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.PointTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("point_type_id");
            entity.Property(e => e.StateGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("state_group_id");
            entity.Property(e => e.UnitId)
                .HasColumnType("int(11)")
                .HasColumnName("unit_id");
        });

        modelBuilder.Entity<VProgramInfoView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_program_info_view");

            entity.Property(e => e.AlarmPriorityFk)
                .HasComment("알람 우선순위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_fk");
            entity.Property(e => e.ComputerFk)
                .HasComment("컴퓨터 ID")
                .HasColumnType("int(11)")
                .HasColumnName("computer_fk");
            entity.Property(e => e.ComputerGroupFk)
                .HasComment("컴퓨터 그룹ID")
                .HasColumnType("int(11)")
                .HasColumnName("computer_group_fk");
            entity.Property(e => e.ComputerName)
                .HasMaxLength(64)
                .HasComment("컴퓨터명")
                .HasColumnName("computer_name");
            entity.Property(e => e.DpName)
                .HasMaxLength(22)
                .HasColumnName("dp_name");
            entity.Property(e => e.DpType)
                .HasMaxLength(11)
                .HasDefaultValueSql("''")
                .HasColumnName("dp_type");
            entity.Property(e => e.ExecuteType)
                .HasComment("실행타입(0:실행안함, 1:콘솔명령, 2:윈도우 서비스)")
                .HasColumnType("tinyint(4)")
                .HasColumnName("execute_type");
            entity.Property(e => e.IpAddr)
                .HasMaxLength(32)
                .HasComment("IP ADDR")
                .HasColumnName("ip_addr");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("프로그램명")
                .HasColumnName("name");
            entity.Property(e => e.ProcFullName)
                .HasMaxLength(256)
                .HasComment("파일이름(경로포함)")
                .HasColumnName("proc_full_name");
            entity.Property(e => e.ProgramDesc)
                .HasMaxLength(256)
                .HasComment("프로그램 설명(버젼정보)")
                .HasColumnName("program_desc");
            entity.Property(e => e.ProgramId)
                .HasComment("프로그램 ID")
                .HasColumnType("int(11)")
                .HasColumnName("program_id");
            entity.Property(e => e.ProgramNo)
                .HasComment("프로그램번호")
                .HasColumnType("int(11)")
                .HasColumnName("program_no");
            entity.Property(e => e.ProgramTypeFk)
                .HasComment("프로그램 타입 ID")
                .HasColumnType("int(11)")
                .HasColumnName("program_type_fk");
            entity.Property(e => e.StartCmd)
                .HasMaxLength(256)
                .HasComment("시작 명령")
                .HasColumnName("start_cmd");
            entity.Property(e => e.StateGroupFk)
                .HasComment("상태 그룹 ID")
                .HasColumnType("int(11)")
                .HasColumnName("state_group_fk");
            entity.Property(e => e.StopCmd)
                .HasMaxLength(256)
                .HasComment("종료 명령")
                .HasColumnName("stop_cmd");
            entity.Property(e => e.TcpPort)
                .HasComment("TCP PORT")
                .HasColumnType("int(11)")
                .HasColumnName("tcp_port");
            entity.Property(e => e.UpdatePeriod)
                .HasComment("프로그램 상태 갱신주기")
                .HasColumnType("int(11)")
                .HasColumnName("update_period");
            entity.Property(e => e.UseFlag)
                .HasComment("사용 여부")
                .HasColumnType("tinyint(4)")
                .HasColumnName("use_flag");
        });

        modelBuilder.Entity<VRealMessageListView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_real_message_list_view");

            entity.Property(e => e.GroupId)
                .HasColumnType("int(1)")
                .HasColumnName("group_id");
            entity.Property(e => e.MsgCount)
                .HasColumnType("int(3)")
                .HasColumnName("msg_count");
            entity.Property(e => e.MsgName)
                .HasMaxLength(16)
                .HasColumnName("msg_name");
            entity.Property(e => e.MsgType)
                .HasColumnType("int(1)")
                .HasColumnName("msg_type");
            entity.Property(e => e.ServerCode)
                .HasMaxLength(4)
                .HasDefaultValueSql("''")
                .HasColumnName("server_code");
        });

        modelBuilder.Entity<VRealPointListView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_real_point_list_view");

            entity.Property(e => e.DpName)
                .HasMaxLength(169)
                .HasColumnName("dp_name");
            entity.Property(e => e.DpType)
                .HasMaxLength(64)
                .HasColumnName("dp_type");
        });

        modelBuilder.Entity<VSnmpInfoView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_snmp_info_view");

            entity.Property(e => e.Address)
                .HasMaxLength(32)
                .HasComment("주소")
                .HasColumnName("address");
            entity.Property(e => e.AlarmPriorityFk)
                .HasComment("알람 우선순위 ID")
                .HasColumnType("int(11)")
                .HasColumnName("alarm_priority_fk");
            entity.Property(e => e.CommunityName)
                .HasMaxLength(32)
                .HasComment("커뮤니티 이름")
                .HasColumnName("community_name");
            entity.Property(e => e.CpuRate)
                .HasComment("CPU 사용률(%)")
                .HasColumnName("cpu_rate");
            entity.Property(e => e.DeviceName)
                .HasMaxLength(64)
                .HasComment("장비 이름")
                .HasColumnName("device_name");
            entity.Property(e => e.DiskRate)
                .HasComment("DISK 사용률(%)")
                .HasColumnName("disk_rate");
            entity.Property(e => e.DpName)
                .HasMaxLength(24)
                .HasColumnName("dp_name");
            entity.Property(e => e.DpType)
                .HasMaxLength(8)
                .HasDefaultValueSql("''")
                .HasColumnName("dp_type");
            entity.Property(e => e.MemRate)
                .HasComment("MEM 사용률(%)")
                .HasColumnName("mem_rate");
            entity.Property(e => e.MemberOfficeFk)
                .HasComment("지역 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_fk");
            entity.Property(e => e.OsTypeFk)
                .HasComment("OS 타입")
                .HasColumnType("int(11)")
                .HasColumnName("os_type_fk");
            entity.Property(e => e.Port)
                .HasComment("포트")
                .HasColumnType("int(11)")
                .HasColumnName("port");
            entity.Property(e => e.PortId)
                .HasMaxLength(512)
                .HasComment("포트 아이디")
                .HasColumnName("port_id");
            entity.Property(e => e.PortValue)
                .HasMaxLength(512)
                .HasComment("포트 값")
                .HasColumnName("port_value");
            entity.Property(e => e.SnmpGroupFk)
                .HasComment("snmp 그룹 아이디")
                .HasColumnType("int(11)")
                .HasColumnName("snmp_group_fk");
            entity.Property(e => e.SnmpGroupName)
                .HasMaxLength(64)
                .HasComment("snmp 그룹 이름")
                .HasColumnName("snmp_group_name");
            entity.Property(e => e.SnmpId)
                .HasComment("아이디")
                .HasColumnType("int(11)")
                .HasColumnName("snmp_id");
            entity.Property(e => e.StateGorupFk)
                .HasComment("상태 그룹 코드")
                .HasColumnType("int(11)")
                .HasColumnName("state_gorup_fk");
            entity.Property(e => e.Status)
                .HasComment("상태")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.TimeOut)
                .HasComment("타임아웃")
                .HasColumnType("int(11)")
                .HasColumnName("time_out");
            entity.Property(e => e.UpdateTime)
                .HasComment("갱신 시간")
                .HasColumnType("timestamp")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<VStationView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_station_view");

            entity.Property(e => e.BsensCode)
                .HasMaxLength(16)
                .HasComment("사업자코드")
                .HasColumnName("bsens_code");
            entity.Property(e => e.InstallDate)
                .HasMaxLength(16)
                .HasComment("설치일자")
                .HasColumnName("install_date");
            entity.Property(e => e.MemberOfficeId)
                .HasComment("지역(사업소) 코드")
                .HasColumnType("bigint(20)")
                .HasColumnName("member_office_id");
            entity.Property(e => e.ModelId)
                .HasComment("연결 모델 ID")
                .HasColumnType("int(11)")
                .HasColumnName("model_id");
            entity.Property(e => e.ModelName)
                .HasMaxLength(64)
                .HasComment("모델명")
                .HasColumnName("model_name");
            entity.Property(e => e.OfficeName)
                .HasMaxLength(64)
                .HasComment("지역(사업소) 명")
                .HasColumnName("office_name");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(16)
                .HasComment("전화번호")
                .HasColumnName("phone_no");
            entity.Property(e => e.StationAdder)
                .HasMaxLength(256)
                .HasComment("스테이션 주소")
                .HasColumnName("station_adder");
            entity.Property(e => e.StationId)
                .HasComment("스테이션 ID")
                .HasColumnType("bigint(20)")
                .HasColumnName("station_id");
            entity.Property(e => e.StationName)
                .HasMaxLength(64)
                .HasComment("개체명")
                .HasColumnName("station_name");
            entity.Property(e => e.StationTypeId)
                .HasComment("스테이션 타입")
                .HasColumnType("int(11)")
                .HasColumnName("station_type_id");
            entity.Property(e => e.StationTypeName)
                .HasMaxLength(64)
                .HasComment("스테이션명")
                .HasColumnName("station_type_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
